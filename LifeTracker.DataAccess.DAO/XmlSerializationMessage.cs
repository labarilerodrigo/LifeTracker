using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationMessage {

        /// <summary>
        /// Create a node of a specified <paramref name="elements"/> in <paramref name="fileName"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="elements"></param>
        public static void SerializeNode(string fileName, string[,] elements) {
            if (!isCreated(fileName))
                InitializeRootNode(fileName);

            XDocument doc = XDocument.Load(fileName);
            XElement root = doc.Root;
            XElement serviceRoot = new XElement("message");
            for (int row = 0; row < elements.GetLength(0); ++row) {
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
        public static void InitializeRootNode(string fileName) {
            XDocument d = new XDocument(
                new XComment("All available message messages sent to professionals in LifeTracker application."),
                new XElement("Messages"));
            d.Declaration = new XDeclaration("1.0", "utf-8", "true");
            d.Save(fileName);
        }

        /// <summary>
        /// File check existency
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static bool isCreated(string fileName) {
            return File.Exists(fileName);
        }

        public static bool Exists(string fileName, string element) {
            bool created = false;
            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> messageServices = doc.Root.Elements();

                foreach (var messageServiceItem in messageServices) {
                    var messageId = messageServiceItem.Elements("messageId").FirstOrDefault().Value.ToString();

                    if (messageId == element) {
                        created = true;
                        return created;
                    }
                }
            }
            return created;
        }

        public static List<List<string>> GetAll(string fileName) {
            List<List<string>> listOfMessages = new List<List<string>>();

            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> messages = doc.Root.Elements();

                foreach (var messageNode in messages) {
                    List<string> listOfMessageItems = new List<string>();
                    foreach (var itemNode in messageNode.Elements()) {
                        listOfMessageItems.Add(itemNode.Value);
                    }
                    listOfMessages.Add(listOfMessageItems);
                }
            }
            return listOfMessages;
        }

        /// <summary>
        /// Remove a root node based on provided <paramref name="element"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="element"></param>
        public static void RemoveNode(string fileName, string id) {
            XDocument doc = XDocument.Load(fileName);
            IEnumerable<XElement> messageRoles = doc.Root.Elements();

            messageRoles.Descendants("messageId")
             .Where(el => el.Value == id).First()
             .Parent
             .Remove();

            doc.Save(fileName);
        }
    }
}
