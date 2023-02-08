using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.Services.IAM.Composite2
{
    public class UserRole : UserRolePermission, IUserRole {

        private IList<IPermission> _children;

        public UserRole() {
            _children = new List<IPermission>();
        }

        public IList<IPermission> Permissions {
            get {
                return _children;
            }
            set { _children = value; }
        }

        public override void AddPermission(IPermission p) {
            if (!_children.Contains(p))
                _children.Add(p);
        }

        public override IList<IPermission> Children() {
            return _children.ToArray();
        }

        public override void RemovePermission(IPermission p) {
            if (_children.Contains(p))
                _children.Remove(p);
        }
    }
}
