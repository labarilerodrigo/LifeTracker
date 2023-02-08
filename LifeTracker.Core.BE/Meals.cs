using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using Type = LifeTracker.Core.Interfaces.Type;

namespace LifeTracker.Core.BE
{
    public class Meals : Entity, IMeals {

        public Meals() {
            TimeStamp = DateTime.Now;
        }

        public Guid MealsId { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Tuple<IFood, decimal>> Portion { get; set; }
        public Type Type { get; set; }
        public string Description { get; set; }
    }

    
}
