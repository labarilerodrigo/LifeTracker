using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace LifeTracker.DataAccess.Mapper.DTO
{
    [XmlRoot("userRoles")]
    [System.Serializable]
    public class UserRoleDTO {

        public UserRoleDTO() {
            Id = Guid.NewGuid();
            TimeStamp = DateTime.Now;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlElement("TimeStamp")]        
        public DateTime TimeStamp { get; set; }

        [XmlElement("Name")]        
        public string Name { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        public IList<IPermission> Permissions { get; set; }
    }

}
