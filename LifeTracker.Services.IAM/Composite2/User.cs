using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.Services.IAM.Composite2
{
    public class User : UserRolePermission, IUser {

        public User() {
            _children = new List<IPermission>();
        }

        private IList<IPermission> _children;
        public IList<IPermission> Permissions {
            get {
                return _children;
            }
            set { _children = value; }
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public bool Allergic { get; set; }
        public string Allergies { get; set; }
        public Intensity Intensity { get; set; }
        public int Availability_In_Hours { get; set; }
        public decimal MaxCalories { get; set; }
        public bool Professional { get; set; }
        public Objective Objective { get; set; }
        public decimal DietCount { get; set; }

        public override void AddPermission(IPermission p) {
            if (!_children.Contains(p))
                _children.Add(p);
        }

        public override IList<IPermission> Children() {
            return _children.ToArray();
        }

        public override void RemovePermission(IPermission p) {
            //if (_children.Contains(p))
                _children.Remove(p);
        }
    }
}
