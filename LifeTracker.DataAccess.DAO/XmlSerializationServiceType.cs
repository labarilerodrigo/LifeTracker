using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationServiceType
    {

        /// <summary>
        /// Create a node of a specified <paramref name="elements"/> in <paramref name="fileName"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="elements"></param>
        public static void SerializeNode(string fileName, string[,] elements)
        {
            if (!isCreated(fileName))
                InitializeRootNode(fileName);

            XDocument doc = XDocument.Load(fileName);
            XElement root = doc.Root;
            XElement serviceRoot = new XElement("service");
            for (int row = 0; row < elements.GetLength(0); ++row)
            {
                XElement service = new XElement(elements[row, 0], elements[row, 1]);
                serviceRoot.Add(service);
            }
            root.Add(serviceRoot);
            doc.Save(fileName);
        }

        /// <summary>
        /// Initialize a XML document for the first time.
        /// </summary>
        /// <param name="fileName"></param>
        public static void InitializeRootNode(string fileName)
        {
            XDocument d = new XDocument(
                new XComment("All available services for LifeTracker application."),
                new XElement("services"));
            d.Declaration = new XDeclaration("1.0", "utf-8", "true");
            d.Save(fileName);
        }

        /// <summary>
        /// File check existency
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static bool isCreated(string fileName)
        {
            return File.Exists(fileName);
        }

        public static bool Exists(string fileName, string name)
        {
            bool created = false;
            if (isCreated(fileName))
            {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> services = doc.Root.Elements();
                foreach (var service in services)
                {
                    foreach (var serviceName in service.Elements("name"))
                    {
                        if (serviceName.Value == name)
                        {
                            created = true;
                            return created;
                        }
                    }
                }
            }
            return created;
        }

        public static List<List<string>> GetAll(string fileName) {
            List<List<string>> listOfServices = new List<List<string>>();

            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> services = doc.Root.Elements();

                foreach (var serviceNode in services) {
                    List<string> listOfServiceItems = new List<string>();
                    foreach (var itemNode in serviceNode.Elements()) {
                        listOfServiceItems.Add(itemNode.Value);
                    }
                    listOfServices.Add(listOfServiceItems);
                }
            }
            return listOfServices;
        }

    }
}
