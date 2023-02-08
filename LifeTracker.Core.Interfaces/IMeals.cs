using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTracker.Core.Interfaces
{
    public interface IMeals : IEntity {
        Guid MealsId { get; set; }
        DateTime TimeStamp { get; set; }
        List<Tuple<IFood, decimal>> Portion { get; set; }
        Type Type { get; set; }
        string Description { get; set; }
    }

    public enum Type {
        Desayuno,
        Almuerzo,
        Merienda,
        Cena
    }
}
