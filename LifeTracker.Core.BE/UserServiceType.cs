using LifeTracker.Core.Interfaces;
using System.Collections.Generic;

namespace LifeTracker.Core.BE
{
    public class UserServiceType : Entity {

        public IUser User { get; set; }

        public IList<IPermission> ServiceTypes { get; set; }

    }
}
