using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTracker.Core.Interfaces
{
    public interface ICrud<T> where T : IEntity {

        T GetId(Guid id);
        IList<T> GetAll();
        IList<T> GetAllWithPermission();
        void Save(T entity);
        void Delete(T entity);
    }
}
