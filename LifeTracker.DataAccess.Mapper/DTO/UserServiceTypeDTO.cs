using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace LifeTracker.DataAccess.Mapper.DTO
{
    [XmlRoot("UserServiceType")]
    [System.Serializable]
    public class UserServiceTypeDTO : IUser, IServiceType {

        public UserServiceTypeDTO() {
            TimeStamp = DateTime.Now;
        }

        [XmlAttribute("User")]
        public IUser User { get; set; }

        [XmlAttribute("ServiceType")]
        public IServiceType ServiceType { get; set; }

        [XmlElement("TimeStamp")]
        public DateTime TimeStamp { get; set; }



        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IPermission> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Gender Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Allergic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Allergies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Intensity Intensity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Availability_In_Hours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Professional { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Objective Objective { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal MaxCalories { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal DietCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Guid IEntity.Id => throw new NotImplementedException();

        public void AddPermission(IPermission p) {
            throw new NotImplementedException();
        }

        public IList<IPermission> Children() {
            throw new NotImplementedException();
        }

        public void RemovePermission(IPermission p) {
            throw new NotImplementedException();
        }
    }

}
