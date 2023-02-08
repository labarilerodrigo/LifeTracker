using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.Core.BE
{
    public class Message : Entity, IMessage {

        public Guid MessageId { get; set; }
        public string UserEmail { get; set; }
        public ProfessionalType ProfessionalType { get; set; }
        public SubjectType Subject { get; set; }
        public string MessageText { get; set; }
        public string MessageResponseText { get; set; }
        public bool WasItAnswered { get; set; }
        public DateTime Date { get; set; }

        // Other attributes
        public List<string> Subjects {
            get {
                return Enum.GetNames(typeof(SubjectType)).ToList();
            }
        }
        
    }

}
