using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationUserServiceType {

        /// <summary>
        /// Create a node of a specified <paramref name="elements"/> in <paramref name="fileName"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="elements"></param>
        public static void SerializeNode(string fileName, List<Tuple<string, string, List<string>>> elements) {
            if (!isCreated(fileName))
                InitializeRootNode(fileName);

            XDocument doc = XDocument.Load(fileName);
            XElement root = doc.Root;
            XElement userserviceRoot = new XElement("UserServiceTypes");

            foreach (var serviceElement in elements) {
                if (serviceElement.Item1 != "services") {
                    // standard nodes
                    XElement userservice = new XElement(serviceElement.Item1, serviceElement.Item2);
                    userserviceRoot.Add(userservice);
                }
                else {
                    // permission nodes
                    XElement permissionRoot = new XElement(serviceElement.Item1);
                    foreach (var permission in serviceElement.Item3)
                    {
                        XElement userservice = new XElement(serviceElement.Item2, permission);
                        permissionRoot.Add(userservice);
                    }
                    userserviceRoot.Add(permissionRoot);
                    break;
                }
            }
            root.Add(userserviceRoot);
            doc.Save(fileName);
        }

        /// <summary>
        /// Initialize a XML document for the first time.
        /// </summary>
        /// <param name="fileName"></param>
        public static void InitializeRootNode(string fileName) {
            XDocument d = new XDocument(
                new XComment("All available Service Types per Users for LifeTracker application."),
                new XElement("UserServiceTypes"));
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
                IEnumerable<XElement> userServices = doc.Root.Elements("UserServiceTypes");

                foreach (var userServiceItem in userServices) {
                    var userId = userServiceItem.Elements("userId").FirstOrDefault().Value.ToString();

                    if (userId == element) {
                        created = true;
                        return created;
                    }
                }
            }
            return created;
        }

        //public static List<List<Tuple<string, string>>> GetAll(string fileName) {
        //    List<Tuple<string, string>> listOfTuples = new List<Tuple<string, string>>();
        //    List<List<Tuple<string, string>>> listOfUsersAndTuples = new List<List<Tuple<string, string>>>();


        //    if (isCreated(fileName)) {
        //        XDocument doc = XDocument.Load(fileName);
        //        IEnumerable<XElement> userServices = doc.Root.Elements("userServices");

        //        foreach (var userServiceItem in userServices) {
        //            listOfTuples = new List<Tuple<string, string>>();

        //            var userId = userServiceItem.Elements("userId").FirstOrDefault().Value.ToString();
        //            var serviceTypeId = userServiceItem.Elements("serviceTypeId").FirstOrDefault().Value.ToString();
        //            listOfTuples.Add(new Tuple<string, string>("userId", userId));
        //            listOfTuples.Add(new Tuple<string, string>("serviceTypeId", serviceTypeId));
        //            listOfUsersAndTuples.Add(listOfTuples);
        //        }
        //    }
        //    return listOfUsersAndTuples;
        //}

        public static List<List<Tuple<string, string, List<string>>>> GetAll(string fileName) {
            List<Tuple<string, string, List<string>>> listOfusersNodes = new List<Tuple<string, string, List<string>>>();
            List<List<Tuple<string, string, List<string>>>> listOfusers = new List<List<Tuple<string, string, List<string>>>>();

            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> userServices = doc.Root.Elements("UserServiceTypes");

                foreach (var itemNode in userServices.Elements()) {
                    if (itemNode.Name == "userId") // initialize list per itemNode
                        listOfusersNodes = new List<Tuple<string, string, List<string>>>();
                    if (itemNode.Name != "services") {
                        // standard nodes
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), itemNode.Value, null));
                    }
                    else {
                        // permission nodes
                        var tupleListOfPermissions = new List<string>();
                        foreach (var permission in itemNode.Elements()) {
                            tupleListOfPermissions.Add(permission.Value);
                        }
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), "serviceTypeId", tupleListOfPermissions));
                        listOfusers.Add(listOfusersNodes);
                    }
                }
            }
            return listOfusers;
        }

        /// <summary>
        /// Remove a root node based on provided <paramref name="element"/>.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="element"></param>
        public static void RemoveNode(string fileName, string id) {
            XDocument doc = XDocument.Load(fileName);
            IEnumerable<XElement> userRoles = doc.Root.Elements();

            userRoles.Descendants("userId")
             .Where(el => el.Value == id).First()
             .Parent
             .Remove();

            doc.Save(fileName);
        }
    }
}
