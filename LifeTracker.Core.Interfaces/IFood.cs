using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTracker.Core.Interfaces
{
     public interface IFood : IEntity {

         Guid FoodId { get; set; }
         DateTime TimeStamp { get; set; }
         string Name { get; set; }
         string Description { get; set; }
         decimal Carbohydrates { get; set; }
         decimal Protein { get; set; }
         decimal Fat { get; set; }
         decimal Vitamin { get; set; }
         decimal Mineral { get; set; }
         decimal Fibre { get; set; }
         decimal Water { get; set; }
         decimal Calories { get; set; }
         decimal Quantity { get; set; }
    }
}
