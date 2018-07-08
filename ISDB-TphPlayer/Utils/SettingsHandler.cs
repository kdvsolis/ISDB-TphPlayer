using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ISDB_TphPlayer.Utils
{
    class SettingsHandler
    {
        public static void SaveSettings(List<string[]> settings)
        {
            using (XmlWriter writer = XmlWriter.Create("settings.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("settings");

                foreach (string[] setting in settings)
                {
                    writer.WriteElementString(setting[0], setting[1]);
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static List<string[]> LoadSettings()
        {
            try
            {
                List<string[]> settings = new List<string[]>();
                List<string> nodeData = new List<string>();
                using (XmlReader reader = XmlReader.Create("settings.xml"))
                {
                    reader.ReadToFollowing("settings");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                            nodeData.Add(reader.Name);
                        if (reader.NodeType == XmlNodeType.Text)
                            nodeData.Add(reader.Value);
                        if (nodeData.Count == 2)
                        {
                            settings.Add(nodeData.ToArray());
                            nodeData.Clear();
                        }
                    }
                }
                return settings;
            }
            catch(Exception)
            {

            }
            return null;
        }


    }
}
