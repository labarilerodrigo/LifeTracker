using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace LifeTracker.Core.BLL
{
    public abstract class CrudBLL<T> : ICrud<T> where T : IEntity
    {
        protected ICrud<T> _crud;

        public void Delete(T entity) {
            _crud.Delete(entity);
        }

        public IList<T> GetAll() {
            return _crud.GetAll();
        }

        public IList<T> GetAllWithPermission() {
            return _crud.GetAllWithPermission();
        }

        public T GetId(Guid id) {
            return _crud.GetId(id);
        }

        public void Save(T entity) {
            _crud.Save(entity);
        }

    }
}
