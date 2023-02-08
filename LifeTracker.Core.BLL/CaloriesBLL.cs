using LifeTracker.Core.BE;
using LifeTracker.Services.IAM.Composite2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTracker.Core.BLL
{
    public class CaloriesBLL {

        public User User { get; set; }
        public Meals Meals { get; set; }

        public CaloriesBLL() {
            User = new User();
            Meals = new Meals();
        }

        public CaloriesBLL(User user, Meals meals) {
            User = user;
            Meals = meals;
        }

        public decimal? CalculateCalories() {
            switch (User.Gender) {
                case Interfaces.Gender.Male:
                    return maleCalories();
                case Interfaces.Gender.Female:
                    return femaleCalories();
                default:
                    return null;
            }
        }

        private decimal maleCalories() {
            //TMB Hombre: 66,4 + (13,75 x peso en kg) + (5 x altura en cm) – (6,7 x edad)
            const decimal factor = 66.4m;
            var weight = User.Weight;
            var height = User.Height;
            var age = User.Age;

            return ((factor) + (13.75m * weight) + (5 * height) - (6.7m * age));
        }

        private decimal femaleCalories() {
            //TMB Mujer: 665 + (9,5 x peso en kg) + (1,8 x altura en cm) – (4,6 x edad)
            const decimal factor = 665m;
            var weight = User.Weight;
            var height = User.Height;
            var age = User.Age;

            return ((factor) + (13.75m * weight) + (5 * height) - (6.7m * age));
        }
    }
}
