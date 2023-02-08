using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerialization {

        public static void SerializeToXml<T>(T obj, string fileName) {
            using (var fileStream = new FileStream(fileName, FileMode.Append)) {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(fileStream, obj);
            }
        }

        public static T DeserializeFromXml<T>(string xml) {
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml)) {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        public static void SerializeElement(string fileName, string element, string value) {
            XmlSerializer ser = new XmlSerializer(typeof(XmlElement));
            XmlElement myElement =
            new XmlDocument().CreateElement(element, "ns");
            myElement.InnerText = value;
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, myElement);
            writer.Close();
        }

        public static void SerializeNode(string fileName, string element, string value) {
            XmlSerializer ser = new XmlSerializer(typeof(XmlNode));
            XmlNode myNode = new XmlDocument().
            CreateNode(XmlNodeType.Element, element, "ns");
            myNode.InnerText = value;
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, myNode);
            writer.Close();
        }

    }
}
