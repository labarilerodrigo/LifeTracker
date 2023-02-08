using System;
using System.Xml.Serialization;

namespace LifeTracker.DataAccess.Mapper.DTO
{
    [XmlRoot("services")]
    [System.Serializable]
    public class ServiceTypeDTO {

        public ServiceTypeDTO() {
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
    }

}
