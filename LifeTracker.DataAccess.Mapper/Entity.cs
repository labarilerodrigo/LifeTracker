using System;
using LifeTracker.Core.Interfaces;

namespace LifeTracker.DataAccess.Mapper
{
    /// <summary>
    /// Abstract class for Entity
    /// </summary>
    public abstract class Entity : IEntity {

        public Guid Id { get; }
        public DateTime TimeStamp { get; set; }
        public Entity() {
            Id = Guid.NewGuid();
            TimeStamp = DateTime.Now;
        }
    }

}
