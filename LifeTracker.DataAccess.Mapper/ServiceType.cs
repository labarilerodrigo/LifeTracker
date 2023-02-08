using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using System;
using System.Configuration;
using System.Collections.Generic;
using LifeTracker.DataAccess.Mapper.DTO;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper
{
    public class ServiceType : ICrud<IServiceType> {

        protected IList<IServiceType> dataContext = new List<IServiceType>();
        protected string xmlDb;

        public ServiceType() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] +"ServiceTypes.xml";
    }

        public void Delete(IServiceType entity) {
            throw new NotImplementedException();
        }

        public IList<IServiceType> GetAll() {
            var services = XmlSerializationServiceType.GetAll(xmlDb);
            dataContext = new List<IServiceType>();    // fresh data for dataContext

            foreach (var service in services) {
                var serviceType = new LifeTracker.Services.IAM.Composite2.ServiceType() {
                    Id = Guid.Parse(service[0]),
                    Name = service[1],
                    Description = service[2]
                };
                dataContext.Add(serviceType);
            }
            return dataContext;
        }

        public IList<IServiceType> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public IServiceType GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(IServiceType entity) {
            var exists = XmlSerializationServiceType.Exists(xmlDb, entity.Name.ToString());

            if (!exists) {
                var serviceType = new ServiceTypeDTO { Name = entity.Name, Description = entity.Description };
                string[,] entries = new string[,] {
                    { "serviceTypeId", serviceType.Id.ToString() },
                    { "name", serviceType.Name },
                    { "description", serviceType.Description },
                    { "timestamp", serviceType.TimeStamp.ToString() }
                };
                XmlSerializationServiceType.SerializeNode(xmlDb, entries);
            }
        }

    }
}
