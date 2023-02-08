using LifeTracker.Core.Interfaces;
using System.Collections.Generic;

namespace LifeTracker.Services.IAM.Composite2
{
    public abstract class UserRolePermission : ServiceEntity, IPermission
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void AddPermission(IPermission p);

        public abstract IList<IPermission> Children();

        public abstract void RemovePermission(IPermission p);
    }
}
