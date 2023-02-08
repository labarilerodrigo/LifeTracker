using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationBackup {

        /// <summary>
        /// Create a node of a specified <paramref name="elements"/> in <paramref name="fileName"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="elements"></param>
        public static void SerializeNode(string fileName, Tuple<string, string, string, string, string, string, string> elements) {
            if (!isCreated(fileName))
                InitializeRootNode(fileName);

            XDocument doc = XDocument.Load(fileName);
            XElement root = doc.Root;

            XElement systemBackupRoot = new XElement("systemBackups");
            XElement systemBackupId = new XElement("systemBackupId", elements.Item1);
            XElement systemUserEmail = new XElement("systemUserEmail", elements.Item2);
            XElement systemOperation = new XElement("systemOperation", elements.Item3);
            XElement systemBackupName = new XElement("systemBackupName", elements.Item4);
            XElement systemBackupDirectory = new XElement("systemBackupDirectory", elements.Item5);
            XElement systemBackupFilename = new XElement("systemBackupFilename", elements.Item6);
            XElement timeStamp = new XElement("timeStamp", elements.Item7);
            systemBackupRoot.Add(systemBackupId);
            systemBackupRoot.Add(systemUserEmail);
            systemBackupRoot.Add(systemOperation);
            systemBackupRoot.Add(systemBackupName);
            systemBackupRoot.Add(systemBackupDirectory);
            systemBackupRoot.Add(systemBackupFilename);
            systemBackupRoot.Add(timeStamp);
            root.Add(systemBackupRoot);

            doc.Save(fileName);
        }

        /// <summary>
        /// Initialize a XML document for the first time.
        /// </summary>
        /// <param name="fileName"></param>
        public static void InitializeRootNode(string fileName) {
            XDocument d = new XDocument(
                new XComment("All available System Backup for LifeTracker application."),
                new XElement("Backup"));
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

        public static bool Exists(string fileName, Tuple<string, string, string, string, string, string, string> elements) {
            bool created = false;
            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> systemBackups = doc.Root.Elements("systemBackups");

                XElement systemBackupId = new XElement("systemBackupId", elements.Item1);
                if (systemBackups.Descendants("systemBackupId").FirstOrDefault().Value == elements.Item1) {
                    created = true;
                    return created;
                }
            }
            return created;
        }

        public static List<List<Tuple<string, string>>> GetAll(string fileName) {
            List<Tuple<string, string>> listOfTuples = new List<Tuple<string, string>>();
            List<List<Tuple<string, string>>> listOfUserBackups = new List<List<Tuple<string, string>>>();


            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> systemBackups = doc.Root.Elements("systemBackups");

                foreach (var systemBackupItem in systemBackups) {
                    listOfTuples = new List<Tuple<string, string>>();

                    var systemBackupId = systemBackupItem.Elements("systemBackupId").FirstOrDefault().Value.ToString();
                    var systemUserEmail = systemBackupItem.Elements("systemUserEmail").FirstOrDefault().Value.ToString();
                    var systemOperation = systemBackupItem.Elements("systemOperation").FirstOrDefault().Value.ToString();
                    var systemBackupName = systemBackupItem.Elements("systemBackupName").FirstOrDefault().Value.ToString();
                    var systemBackupDirectory = systemBackupItem.Elements("systemBackupDirectory").FirstOrDefault().Value.ToString();
                    var systemBackupFilename = systemBackupItem.Elements("systemBackupFilename").FirstOrDefault().Value.ToString();
                    var timeStamp = systemBackupItem.Elements("timeStamp").FirstOrDefault().Value.ToString();
                    
                    listOfTuples.Add(new Tuple<string, string>("systemBackupId", systemBackupId));
                    listOfTuples.Add(new Tuple<string, string>("systemUserEmail", systemUserEmail));
                    listOfTuples.Add(new Tuple<string, string>("systemOperation", systemOperation));
                    listOfTuples.Add(new Tuple<string, string>("systemBackupName", systemBackupName));
                    listOfTuples.Add(new Tuple<string, string>("systemBackupDirectory", systemBackupDirectory));
                    listOfTuples.Add(new Tuple<string, string>("systemBackupFilename", systemBackupFilename));
                    listOfTuples.Add(new Tuple<string, string>("timeStamp", timeStamp));
                    listOfUserBackups.Add(listOfTuples);
                }
            }
            return listOfUserBackups;
        }

    }
}
