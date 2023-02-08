using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LifeTracker.DataAccess.Mapper.DTO
{
    [XmlRoot("users")]
    public class UserDTO : IUser {

        public UserDTO() {
            Id = Guid.NewGuid();
            TimeStamp = DateTime.Now;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }
        [XmlElement("TimeStamp")]
        public DateTime TimeStamp { get; set; }
        [XmlElement("Email")]
        public string Email { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
        public IList<IPermission> Permissions { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public bool Allergic { get; set; }
        public string Allergies { get; set; }
        public Intensity Intensity { get; set; }
        public int Availability_In_Hours { get; set; }
        public bool Professional { get; set; }
        public Objective Objective { get; set; } 
        public decimal MaxCalories { get; set; }
        public decimal DietCount { get; set; }

    }
}
