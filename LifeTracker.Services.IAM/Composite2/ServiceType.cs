using LifeTracker.Core.Interfaces;
using System.Collections.Generic;

namespace LifeTracker.Services.IAM.Composite2
{
    /// <summary>
    /// LifeTracker Services
    /// </summary>
    /// <remarks>IAM, Professional Consultancy, Backup and Others Services.</remarks>
    public class ServiceType : UserRolePermission, IServiceType { 
        
        public override void AddPermission(IPermission p) { }

        public override IList<IPermission> Children() {
            return new List<IPermission>();
        }

        public override void RemovePermission(IPermission p) { }
    }
}
