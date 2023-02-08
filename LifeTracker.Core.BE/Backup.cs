
using System;

namespace LifeTracker.Core.BE
{
    public class Backup : Entity {

        public Backup() {
            TimeStamp = DateTime.Now;
        }

        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Filename { get; set; }
        public DateTime TimeStamp { get; set; }
        public Operation Operation { get; set; }

    }

    public enum Operation {
        Backup,
        Restore
    }
}
