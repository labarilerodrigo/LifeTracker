using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using LifeTracker.DataAccess.Mapper.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper {

    public class UserServiceType : ICrud<LifeTracker.Core.BE.UserServiceType> {

        protected IList<LifeTracker.Core.BE.UserServiceType> dataContext = new List<LifeTracker.Core.BE.UserServiceType>();
        protected string xmlDb;

        public UserServiceType() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] + "UserServiceType.xml";
        }

        public void Delete(LifeTracker.Core.BE.UserServiceType entity) {
            var exists = XmlSerializationUserServiceType.Exists(xmlDb, entity.User.Id.ToString()); 
            if (exists) {
                dataContext = new List<LifeTracker.Core.BE.UserServiceType>();    // fresh data for dataContext
                XmlSerializationUserServiceType.RemoveNode(xmlDb, entity.User.Id.ToString());
                GetAll();
            }
        }

        public IList<LifeTracker.Core.BE.UserServiceType> GetAll() {
            var listOfUsers = XmlSerializationUserServiceType.GetAll(xmlDb);
            dataContext = new List<LifeTracker.Core.BE.UserServiceType>();    // fresh data for dataContext

            foreach (var users in listOfUsers) {
                User userMpp = new User();
                
                //var userParsed = userMpp.GetId(Guid.Parse(users[0].Item2));
                var user = new LifeTracker.Services.IAM.Composite2.User() {
                    Id = Guid.Parse(users[0].Item2)
                    //Email = userParsed.Email,
                    //Password = userParsed.Password
                };
                List<IPermission> permissions = new List<IPermission>();
                foreach (var permission in users[2].Item3) {
                    ServiceType serviceTypeMpp = new ServiceType();
                    var serviceType = serviceTypeMpp.GetId(Guid.Parse(permission));
                    permissions.Add(serviceType);
                }

                var service = new LifeTracker.Core.BE.UserServiceType() {
                    User = user,
                    ServiceTypes = permissions
                };
                dataContext.Add(service);
            }
            return dataContext;
        }

        public IList<Core.BE.UserServiceType> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public LifeTracker.Core.BE.UserServiceType GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(LifeTracker.Core.BE.UserServiceType entity) {
            var exists = XmlSerializationUserServiceType.Exists(xmlDb, entity.User.Id.ToString());

            if (!exists) {
                var tupleListOfPermissions = getPermissions(entity);

                var usersWithServices = new List<Tuple<string, string, List<string>>> {
                    new Tuple<string, string, List<string>>("userId", entity.User.Id.ToString(), null),
                    new Tuple<string, string, List<string>>("timestamp", DateTime.Now.ToString(), null),
                    new Tuple<string, string, List<string>>("services", "serviceTypeId", tupleListOfPermissions) };

                XmlSerializationUserServiceType.SerializeNode(xmlDb, usersWithServices);
            }
            else {
                var user = GetId(entity.User.Id);
                if (user != null) {
                    if (entity.ServiceTypes.Count != entity.ServiceTypes.Count) {
                        // rebuild all user custom services
                        Delete(user);
                        Save(entity);
                    }
                }
            }
        }

        private List<string> getPermissions(LifeTracker.Core.BE.UserServiceType entity) {
            var tupleListOfPermissions = new List<string>();
            entity.ServiceTypes.ToList().ForEach(x => { tupleListOfPermissions.Add(x.Id.ToString()); });
            return tupleListOfPermissions;
        }
    }

} 
