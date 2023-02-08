using System;
using System.Collections.Generic;

namespace LifeTracker.Core.Interfaces
{

    public interface IUserRole : IEntity, IPermission {
        new Guid Id { get; set; }
        new string Name { get; set; }
        IList<IPermission> Permissions { get; set; }
    }
}
