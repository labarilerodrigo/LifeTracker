using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using LifeTracker.DataAccess.Mapper.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper
{
    public abstract class Crud<T> : ICrud<T> where T : IEntity
    {
        protected IList<T> dataContext;
        public Crud() {
            dataContext = new List<T>();
        }

        public void Delete(T entity) {
            this.dataContext.Remove(entity);
        }

        public IList<T> GetAll() {
            return dataContext;
        }

        public IList<T> GetAllWithPermission() {
            return dataContext;
        }

        public T GetId(Guid id) {
            return dataContext.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(T entity) {
            if (dataContext.Contains(entity)) {
                // Serialize objects to XML
                
            }
            else {
                dataContext.Add(entity);
                XmlSerialization.SerializeToXml<T>(entity, @"C:\Users\RLabarile\Dropbox\Facultad\Analista Programador\En Curso\20 - Trabajo Final\TPs\VS_Solution\LifeTracker.db.xml");
            }

        }
    }
}
