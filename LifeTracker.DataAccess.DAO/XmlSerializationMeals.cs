using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationMeals {

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
            XElement mealsRoot = new XElement("Meals");

            foreach (var serviceElement in elements) {
                if (serviceElement.Item1 != "foods") {
                    // standard nodes
                    XElement meals = new XElement(serviceElement.Item1, serviceElement.Item2);
                    mealsRoot.Add(meals);
                }
                else {
                    // food nodes
                    XElement foodRoot = new XElement(serviceElement.Item1);
                    foreach (var food in serviceElement.Item3) {
                        XElement meals = new XElement(serviceElement.Item2, food);
                        foodRoot.Add(meals);
                    }
                    mealsRoot.Add(foodRoot);
                    break;
                }
            }
            root.Add(mealsRoot);
            doc.Save(fileName);
        }

        /// <summary>
        /// Initialize a XML document for the first time.
        /// </summary>
        /// <param name="fileName"></param>
        public static void InitializeRootNode(string fileName) {
            XDocument d = new XDocument(
                new XComment("All available Service Types per Users for LifeTracker application."),
                new XElement("AllMeals"));
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
                IEnumerable<XElement> mealss = doc.Root.Elements();

                foreach (var mealsItem in mealss) {
                    var mealsId = mealsItem.Elements("mealsDescription").FirstOrDefault().Value.ToString();

                    if (mealsId == element) {
                        created = true;
                        return created;
                    }
                }
            }
            return created;
        }

        public static List<List<Tuple<string, string, List<string>>>> GetAll(string fileName) {
            List<Tuple<string, string, List<string>>> listOfusersNodes = new List<Tuple<string, string, List<string>>>();
            List<List<Tuple<string, string, List<string>>>> listOfusers = new List<List<Tuple<string, string, List<string>>>>();

            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> mealss = doc.Root.Elements("Meals");

                foreach (var itemNode in mealss.Elements()) {
                    if (itemNode.Name == "mealsId") // initialize list per itemNode
                        listOfusersNodes = new List<Tuple<string, string, List<string>>>();
                    if (itemNode.Name != "foods") {
                        // standard nodes
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), itemNode.Value, null));
                    }
                    else {
                        // food nodes
                        var tupleListOffoods = new List<string>();
                        foreach (var food in itemNode.Elements()) {
                            tupleListOffoods.Add(food.Value);
                        }
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), "foodId", tupleListOffoods));
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

            userRoles.Descendants("mealsId")
             .Where(el => el.Value == id).First()
             .Parent
             .Remove();

            doc.Save(fileName);
        }
    }
}
