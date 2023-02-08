 using System.Collections.Generic;

namespace LifeTracker.Core.Interfaces
{
    public interface IPermission : IEntity {

        string Name { get; set; }
        string Description { get; set; }
        void AddPermission(IPermission p);
        void RemovePermission(IPermission p);
        IList<IPermission> Children(); 
    }
}
