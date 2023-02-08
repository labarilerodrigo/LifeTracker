using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using LifeTracker.DataAccess.Mapper.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper {

    public class User : ICrud<IUser> {

        protected IList<IUser> dataContext = new List<IUser>();
        protected IList<IPermission> dataContextPermission = new List<IPermission>();
        protected string xmlDb;

        public User() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] + "Users.xml";
        }

        public void Delete(IUser entity) {
            var exists = XmlSerializationUser.Exists(xmlDb, entity.Email.ToString());

            if (exists) {
                dataContext = new List<IUser>();    // fresh data for dataContext
                XmlSerializationUser.RemoveNode(xmlDb, entity.Id.ToString());
                GetAll();
            }
        }

        public IList<IUser> GetAll() {
            var listOfUsers = XmlSerializationUser.GetAll(xmlDb);
            dataContext = new List<IUser>();    // fresh data for dataContext
            
            foreach (var users in listOfUsers) {
                var userId = users[0].Item2;
                var userName = users[1].Item2;
                var password = users[2].Item2;
                var age = users[3].Item2;
                var gender = (Gender)Enum.Parse(typeof(Gender), users[4].Item2.ToString());
                var weight = users[5].Item2;
                var height = users[6].Item2;
                var allergic = users[7].Item2;
                var allergies = users[8].Item2;
                var intensity = (Intensity)Enum.Parse(typeof(Intensity), users[9].Item2.ToString());
                var availabilityInHours = users[10].Item2;
                var professional = users[11].Item2;
                var objective = (Objective)Enum.Parse(typeof(Objective), users[12].Item2.ToString());
                var maxCalories = Convert.ToDecimal(users[13].Item2);
                var dietCount = Convert.ToDecimal(users[14].Item2);
                var user = new LifeTracker.Services.IAM.Composite2.User() {
                    Id = Guid.Parse(userId),
                    Email = userName,
                    Password = password,
                    Age = Convert.ToInt32(age),
                    Gender = gender,
                    Weight = Convert.ToDecimal(weight),
                    Height = Convert.ToDecimal(height),
                    Allergic = Convert.ToBoolean(allergic),
                    Allergies = allergies,
                    Intensity = intensity,
                    Availability_In_Hours = Convert.ToInt32(availabilityInHours),
                    Professional = Convert.ToBoolean(professional),
                    Objective = objective,
                    MaxCalories = maxCalories,
                    DietCount = dietCount
                };

                foreach (var permission in users[15].Item3) {
                    UserRole userRoleMpp = new UserRole();
                    var userRole = userRoleMpp.GetId(Guid.Parse(permission));
                    user.AddPermission(userRole);
                }
                dataContext.Add(user);
            }
            return dataContext;
        }

        public IList<IUser> GetAllWithPermission() {
            var listOfUsers = XmlSerializationUser.GetAll(xmlDb);
            dataContext = new List<IUser>();    // fresh data for dataContext

            foreach (var users in listOfUsers) {
                var userId = users[0].Item2;
                var userName = users[1].Item2;
                var password = users[2].Item2;
                var age = users[3].Item2;
                var gender = (Gender)Enum.Parse(typeof(Gender), users[4].Item2.ToString());
                var weight = users[5].Item2;
                var height = users[6].Item2;
                var allergic = users[7].Item2;
                var allergies = users[8].Item2;
                var intensity = (Intensity)Enum.Parse(typeof(Intensity), users[9].Item2.ToString());
                var availabilityInHours = users[10].Item2;
                var professional = users[11].Item2;
                var objective = (Objective)Enum.Parse(typeof(Objective), users[12].Item2.ToString());
                var maxCalories = Convert.ToDecimal(users[13].Item2);
                var dietCount = Convert.ToDecimal(users[14].Item2);
                var user = new LifeTracker.Services.IAM.Composite2.User() {
                    Id = Guid.Parse(userId),
                    Email = userName,
                    Password = password,
                    Age = Convert.ToInt32(age),
                    Gender = gender,
                    Weight = Convert.ToDecimal(weight),
                    Height = Convert.ToDecimal(height),
                    Allergic = Convert.ToBoolean(allergic),
                    Allergies = allergies,
                    Intensity = intensity,
                    Availability_In_Hours = Convert.ToInt32(availabilityInHours),
                    Professional = Convert.ToBoolean(professional),
                    Objective = objective,
                    MaxCalories = maxCalories,
                    DietCount = dietCount
                };
                foreach (var permission in users[15].Item3) {
                    UserRole userRoleMpp = new UserRole();
                    var userRole = userRoleMpp.GetId(Guid.Parse(permission));

                    if (userRole.Name == "User Permission") {
                        UserServiceType userServiceTypeMpp = new UserServiceType();
                        var services = userServiceTypeMpp.GetAll().Where(x => x.User.Id.ToString() == userId).FirstOrDefault();
                        if (services != null) {
                            foreach (var customPermission in services.ServiceTypes)
                                userRole.AddPermission(customPermission);
                        }
                    }
                    user.AddPermission(userRole);
                }
                dataContext.Add(user);
            }
            return dataContext;
        }

        public IUser GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(IUser entity) {
            var exists = XmlSerializationUser.Exists(xmlDb, entity.Email.ToString());

            if (!exists) {
                var user = new UserDTO { 
                    Email = entity.Email, 
                    Password = entity.Password, 
                    Age = entity.Age, 
                    Gender = entity.Gender, 
                    Weight = entity.Weight, 
                    Height = entity.Height, 
                    Allergic = entity.Allergic, 
                    Allergies = entity.Allergies, 
                    Intensity = entity.Intensity, 
                    Availability_In_Hours = entity.Availability_In_Hours,
                    Permissions = entity.Permissions,
                    Professional = entity.Professional,
                    Objective = entity.Objective,
                    MaxCalories = entity.MaxCalories,
                    DietCount = entity.DietCount
                };

                var tupleListOfPermissions = new List<string>();
                user.Permissions.ToList().ForEach(x => { tupleListOfPermissions.Add(x.Id.ToString()); });

                var usersWithServices = new List<Tuple<string, string, List<string>>> {
                    new Tuple<string, string, List<string>>("userId", user.Id.ToString(), null),
                    new Tuple<string, string, List<string>>("email", user.Email, null),
                    new Tuple<string, string, List<string>>("password", user.Password, null),
                    new Tuple<string, string, List<string>>("age", user.Age.ToString(), null),
                    new Tuple<string, string, List<string>>("gender", user.Gender.ToString(), null),
                    new Tuple<string, string, List<string>>("weight", user.Weight.ToString(), null),
                    new Tuple<string, string, List<string>>("height", user.Height.ToString(), null),
                    new Tuple<string, string, List<string>>("allergic", user.Allergic.ToString(), null),
                    new Tuple<string, string, List<string>>("allergies", user.Allergies, null),
                    new Tuple<string, string, List<string>>("intensity", user.Intensity.ToString(), null),
                    new Tuple<string, string, List<string>>("availabilityInHours", user.Availability_In_Hours.ToString(), null),
                    new Tuple<string, string, List<string>>("professional", user.Professional.ToString(), null),
                    new Tuple<string, string, List<string>>("objective", user.Objective.ToString(), null),
                    new Tuple<string, string, List<string>>("maxCalories", user.MaxCalories.ToString(), null),
                    new Tuple<string, string, List<string>>("dietCount", user.DietCount.ToString(), null),
                    new Tuple<string, string, List<string>>("userRoles", "userRoleId", tupleListOfPermissions) };

                XmlSerializationUser.SerializeNode(xmlDb, usersWithServices);
            }
            else {
                var user = GetId(entity.Id);
                if (user != null) {
                    if (
                           (user.Permissions.Count != entity.Permissions.Count)
                        || (user.Age != entity.Age) 
                        || (user.Weight != entity.Weight) 
                        || user.Height != entity.Height 
                        || user.Gender != entity.Gender 
                        || user.Allergic != entity.Allergic 
                        || user.Allergies != entity.Allergies 
                        || user.Intensity != entity.Intensity 
                        || user.Availability_In_Hours != entity.Availability_In_Hours
                        || user.Professional != entity.Professional
                        || user.Objective != entity.Objective
                        || user.MaxCalories != entity.MaxCalories
                        || user.DietCount != entity.DietCount) {
                        // rebuild all user roles for the user
                        Delete(user);
                        Save(entity);
                    }
                }                
            }
        }
    }

} 
