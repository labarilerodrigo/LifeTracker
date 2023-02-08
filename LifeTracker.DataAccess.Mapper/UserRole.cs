using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using LifeTracker.DataAccess.Mapper.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper
{
    public class UserRole : ICrud<IUserRole>
    {
        protected IList<IUserRole> dataContext = new List<IUserRole>();
        protected IList<IPermission> dataContextPermission = new List<IPermission>();
        protected string xmlDb;

        public UserRole() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] + "UserRoles.xml";
        }

        public void Delete(IUserRole entity) {
            throw new NotImplementedException();
        }

        public IList<IUserRole> GetAll() {
            var listOfuserRoles = XmlSerializationUserRole.GetAll(xmlDb);
            dataContext = new List<IUserRole>();    // fresh data for dataContext

            foreach (var userRoles in listOfuserRoles) {
                var userRoleId = userRoles[0].Item2;
                var userRoleName = userRoles[1].Item2;
                var UserRole = new LifeTracker.Services.IAM.Composite2.UserRole() {
                    Id = Guid.Parse(userRoleId),
                    Name = userRoleName
                };
                foreach (var permission in userRoles[3].Item3) {
                    ServiceType serviceTypeMpp = new ServiceType();
                    var serviceType = serviceTypeMpp.GetId(Guid.Parse(permission));
                    UserRole.AddPermission(serviceType);
                }
                dataContext.Add(UserRole);
            }
            return dataContext;
        }

        public IList<IUserRole> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public IUserRole GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(IUserRole entity) {
            var exists = XmlSerializationUserRole.Exists(xmlDb, entity.Name.ToString());

            if (!exists) {
                var UserRole = new UserRoleDTO { Name = entity.Name, Permissions = entity.Children() };

                var tupleListOfPermissions = new List<string>();
                UserRole.Permissions.ToList().ForEach(x => { tupleListOfPermissions.Add(x.Id.ToString()); });

                var userRolesWithServices = new List<Tuple<string, string, List<string>>> {
                    new Tuple<string, string, List<string>>("userRoleId", UserRole.Id.ToString(), null),
                    new Tuple<string, string, List<string>>("name", UserRole.Name, null),
                    new Tuple<string, string, List<string>>("timestamp", UserRole.TimeStamp.ToString(), null),
                    new Tuple<string, string, List<string>>("services", "serviceTypeId", tupleListOfPermissions) };
                
                XmlSerializationUserRole.SerializeNode(xmlDb, userRolesWithServices);
            }
        }
    }

}
