﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LifeTracker.DataAccess.DAO
{
    public static class XmlSerializationUser {

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
            XElement userRoleRoot = new XElement("users");

            foreach(var roleElement in elements) {
                if(roleElement.Item1 != "userRoles") {
                    // standard nodes
                    XElement userRole = new XElement(roleElement.Item1, roleElement.Item2);
                    userRoleRoot.Add(userRole);
                }
                else {
                    // permission nodes
                    XElement permissionRoot = new XElement(roleElement.Item1);
                    foreach (var permission in roleElement.Item3) {
                        XElement userRole = new XElement(roleElement.Item2, permission);
                        permissionRoot.Add(userRole);
                    }
                    userRoleRoot.Add(permissionRoot);
                    break;
                }

            }
            root.Add(userRoleRoot);
            doc.Save(fileName);
        }

        /// <summary>
        /// Initialize a XML document for the first time.
        /// </summary>
        /// <param name="fileName"></param>
        public static void InitializeRootNode(string fileName) {
            XDocument d = new XDocument(
                new XComment("All available user roles for LifeTracker application."),
                new XElement("userRoles"));
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

        public static bool Exists(string fileName, string name) {
            bool created = false;
            if (isCreated(fileName)) {
                XDocument doc = XDocument.Load(fileName);
                IEnumerable<XElement> userRoles = doc.Root.Elements();
                foreach (var userRole in userRoles) {
                    foreach (var userRoleName in userRole.Elements("email")) {
                        if (userRoleName.Value == name) {
                            created = true;
                            return created;
                        }
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
                IEnumerable<XElement> userRoles = doc.Root.Elements();

                foreach (var itemNode in userRoles.Elements()) {
                    if(itemNode.Name == "userId") // initialize list per itemNode
                        listOfusersNodes = new List<Tuple<string, string, List<string>>>();
                    if (itemNode.Name != "userRoles") {
                        // standard nodes
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), itemNode.Value, null));
                    }
                    else {
                        // permission nodes
                        var tupleListOfPermissions = new List<string>();
                        foreach (var permission in itemNode.Elements()) {
                            tupleListOfPermissions.Add(permission.Value);
                        }
                        listOfusersNodes.Add(new Tuple<string, string, List<string>>(itemNode.Name.ToString(), "userRoleId", tupleListOfPermissions));
                        listOfusers.Add(listOfusersNodes);
                    }                    
                }
            }
            return listOfusers;
        }

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
