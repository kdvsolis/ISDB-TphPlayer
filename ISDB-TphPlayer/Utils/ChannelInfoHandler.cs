using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MediaInfoNET;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Security;

namespace ISDB_TphPlayer.Utils
{
    class ChannelInfoHandler
    {

        public static int ScanServiceIDsPerFrequency(string frequency, string bandwidth, bool resetChannelList)
        {
            int count = 0;
            string channelXml = "";
            Dictionary<string, List<string[]>> channelDataHolder = new Dictionary<string, List<string[]>>();
            Process process = new Process();
            
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = @"DVPiper.exe";
            process.StartInfo.Arguments = "-type DVB-T -frequency " + frequency + " -bandwidth " + bandwidth + " -command scan(file(\"" + frequency + ".xml\")) -scanmaxtime 10000 -emptyexit";
            process.Start();
            process.WaitForExit();

            channelXml = System.IO.File.ReadAllText(frequency + ".xml");
            System.IO.File.Delete(frequency + ".xml");

            using (XmlReader reader = XmlReader.Create(new StringReader(channelXml)))
            {
                channelDataHolder.Add(frequency, new List<string[]>());
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "program")
                        {
                            if (!reader["name"].Contains("DVPiper: Unknown 1st encoding:"))
                            {
                                channelDataHolder[frequency].Add(new string[] { reader["id"], reader["name"] });
                                count++;
                            }
                        }
                    }
                }
            }

            if (resetChannelList)
            {
                using (XmlWriter writer = XmlWriter.Create("channelinfolist.xml"))
                {

                    writer.WriteStartDocument();
                    writer.WriteStartElement("channellist");
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }

            XDocument doc = XDocument.Load("channelinfolist.xml");
            foreach (KeyValuePair<string, List<string[]>> channelData in channelDataHolder)
            {
                doc.Element("channellist").Add(new XElement("frequency", new XAttribute("number", channelData.Key)));
                foreach (string[] channelInfo in channelData.Value)
                {
                    doc.Element("channellist")
                       .Elements("frequency").First(x => x.Attribute("number").Value == channelData.Key)
                       .Add(new XElement("channel", new XAttribute("ID", channelInfo[0]), new XAttribute("name", channelInfo[1]))); 
                }
            }
            doc.Save("channelinfolist.xml");
            return count;
        }

        public static Dictionary<string, List<string[]>> GetChannelInfoList()
        {
            try
            {
                Dictionary<string, List<string[]>> channelInfoHolder = new Dictionary<string, List<string[]>>();
                XDocument doc = XDocument.Load("channelinfolist.xml");

                IEnumerable<XElement> frequencyInfoSource = doc.Element("channellist").Elements("frequency");
                foreach (XElement frequency in frequencyInfoSource)
                {
                    IEnumerable<XElement> frequencyContents = frequency.Elements("channel");
                    channelInfoHolder[frequency.Attribute("number").Value] = new List<string[]>();
                    foreach (XElement channelInfo in frequencyContents)
                    {
                        channelInfoHolder[frequency.Attribute("number").Value].Add(new string[] { channelInfo.Attribute("ID").Value, channelInfo.Attribute("name").Value });
                    }
                }
                return channelInfoHolder;
            }
            catch(Exception)
            {

            }
            return null;
        }

        public static List<string[]> GetEPGData(string frequency, string bandwidth, string id)
        {
            List<string[]> epgData = new List<string[]>();
            MediaFile tsFile = null;
            string tsData = "";
            MatchCollection matches = null;
            XDocument doc = null;
            IEnumerable<XElement> epgInfoSource = null;
            Process process = new Process();

            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = @"DVPiper.exe";
            process.StartInfo.Arguments = "-type DVB-T -frequency " + frequency + " -bandwidth " + bandwidth + " -command \"record(rid(123),send(file('" + frequency + ".ts')))\" -command sleep(2000) -command exit";
            process.Start();
            process.WaitForExit();

            tsFile = new MediaFile(frequency + ".ts");
            tsData = Regex.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?><data>" + tsFile.MediaInfo_HTML.Replace("&nbsp;", "").Replace(" nowrap", "") + "</data>", " colspan=[0-9]+", "");
            matches = Regex.Matches(tsData, "(>)([^<>]+)(<)");
            System.IO.File.Delete(frequency + ".ts");
            foreach (Match match in matches)
            {
                tsData = tsData.Replace(match.Groups[2].Value, SecurityElement.Escape(match.Groups[2].Value));
            }

            tsData = new string(tsData.ToCharArray().Where(ch => XmlConvert.IsXmlChar(ch)).ToArray());

            doc = XDocument.Load(new StringReader(tsData));
            epgInfoSource = doc.Element("data")
                               .Elements("table").Where(x => Regex.Match(x.Element("thead").Element("tr").Element("th").Value, "Menu #[0-9]+").Success &&
                                                             Regex.Match(x.Element("tbody").Elements("tr").ElementAt(1).Elements("td").ElementAt(1).Value.Trim(), id + " [(]0x[0-9a-fA-F]+[)]").Success);

            for (int i = 0; i < epgInfoSource.Elements("tbody").Elements("tr").Where(x => x.Element("td").Value.Contains("UTC")).Elements("td").Count(); i += 2)
            {
                var detail = (new string[] { epgInfoSource.Elements("tbody").Elements("tr").Where(x => x.Element("td").Value.Contains("UTC")).Elements("td").ElementAt(i).Value })
                                  .Concat(epgInfoSource.Elements("tbody").Elements("tr").Where(x => x.Element("td").Value.Contains("UTC")).Elements("td").ElementAt(i + 1).Value.Split('/'));
                epgData.Add(detail.ToArray());
            }
            return epgData;
        }
    }
}
