using LifeTracker.Core.Interfaces;
using System;

namespace LifeTracker.Core.BE
{
    public class Food : Entity, IFood {

        public Food() {
            TimeStamp = DateTime.Now;
        }

        public Guid FoodId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Vitamin { get; set; }
        public decimal Mineral { get; set; }
        public decimal Fibre { get; set; }
        public decimal Water { get; set; }
        public decimal Calories { get; set; }
        public decimal Quantity { get; set; }
    }
}
