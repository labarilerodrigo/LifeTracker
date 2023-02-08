using System;
using LifeTracker.Core.Interfaces;

namespace LifeTracker.Core.BE
{
    /// <summary>
    /// Abstract class for Entity
    /// </summary>
    public abstract class Entity : IEntity {

        public Guid Id { get; }

        public Entity() {
            Id = Guid.NewGuid();
        }
    }

}
