using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM.Composite2;
using System;
using System.Collections.Generic;
using System.Linq;
using Type = LifeTracker.Core.Interfaces.Type;

namespace LifeTracker.Core.BLL
{
    public class DietBLL : CrudBLL<Meals> {

        private LifeTracker.DataAccess.Mapper.Food _foodMpp;
        private LifeTracker.DataAccess.Mapper.Meals _mealsMpp;

        public DietBLL() {
            _foodMpp = new DataAccess.Mapper.Food();
            _mealsMpp = new DataAccess.Mapper.Meals();
        }

        public void SetDefaultDiets() {

            #region Foods
            // food
            LifeTracker.Core.BE.Food food1 = new BE.Food() {
                Name = "Pescado",
                Description = "Pescado Blanco",
                Carbohydrates = 1,
                Protein = 18,
                Fat = 15,
                Calories = 217,
                Quantity = 100
            };
            _foodMpp.Save(food1);

            LifeTracker.Core.BE.Food food2 = new BE.Food() {
                Name = "Pescado",
                Description = "Dorado Pescado",
                Carbohydrates = 0,
                Protein = 18,
                Fat = 1,
                Calories = 77,
                Quantity = 100
            };
            _foodMpp.Save(food2);

            LifeTracker.Core.BE.Food food3 = new BE.Food() {
                Name = "Bagre",
                Description = "Pescado",
                Carbohydrates = 0,
                Protein = 20,
                Fat = 13,
                Calories = 228,
                Quantity = 100
            };
            _foodMpp.Save(food3);

            LifeTracker.Core.BE.Food food4 = new BE.Food() {
                Name = "Atún",
                Description = "Pescado",
                Carbohydrates = 0,
                Protein = 29,
                Fat = 1,
                Calories = 130,
                Quantity = 100
            };
            _foodMpp.Save(food4);

            LifeTracker.Core.BE.Food food5 = new BE.Food() {
                Name = "Carne",
                Description = "Carne Asada",
                Carbohydrates = 0,
                Protein = 5,
                Fat = 4,
                Calories = 56,
                Quantity = 50
            };
            _foodMpp.Save(food5);

            LifeTracker.Core.BE.Food food6 = new BE.Food() {
                Name = "Carne",
                Description = "Carne Picaña",
                Carbohydrates = 0,
                Protein = 0,
                Fat = 0,
                Calories = 200,
                Quantity = 100
            };
            _foodMpp.Save(food6);

            LifeTracker.Core.BE.Food food7 = new BE.Food() {
                Name = "Carne",
                Description = "Carne Cerdo",
                Carbohydrates = 3,
                Protein = 30,
                Fat = 15,
                Calories = 484,
                Quantity = 150
            };
            _foodMpp.Save(food7);

            LifeTracker.Core.BE.Food food8 = new BE.Food() {
                Name = "Queso",
                Description = "Queso Brie",
                Carbohydrates = 0,
                Protein = 6,
                Fat = 8,
                Calories = 92,
                Quantity = 28
            };
            _foodMpp.Save(food8);

            LifeTracker.Core.BE.Food food9 = new BE.Food() {
                Name = "Queso",
                Description = "Queso Manchego Curado",
                Carbohydrates = 0,
                Protein = 6,
                Fat = 8,
                Calories = 98,
                Quantity = 28
            };
            _foodMpp.Save(food9);

            LifeTracker.Core.BE.Food food10 = new BE.Food() {
                Name = "Queso",
                Description = "Queso Cremoso",
                Carbohydrates = 0,
                Protein = 5,
                Fat = 7,
                Calories = 83,
                Quantity = 28
            };
            _foodMpp.Save(food10);

            LifeTracker.Core.BE.Food food11 = new BE.Food() {
                Name = "Yogurt",
                Description = "Yogurt Natural",
                Carbohydrates = 29,
                Protein = 7,
                Fat = 7,
                Calories = 210,
                Quantity = 250
            };
            _foodMpp.Save(food11);

            LifeTracker.Core.BE.Food food12 = new BE.Food() {
                Name = "Agua",
                Description = "Agua Mineral",
                Carbohydrates = 0,
                Protein = 0,
                Fat = 0,
                Calories = 0,
                Quantity = 0,
                Water = 100
            };
            _foodMpp.Save(food12);

            LifeTracker.Core.BE.Food food13 = new BE.Food() {
                Name = "Café",
                Description = "Café con Leche",
                Carbohydrates = 9,
                Protein = 6,
                Fat = 3,
                Calories = 86,
                Quantity = 200,
                Water = 0
            };
            _foodMpp.Save(food13);
            #endregion

            #region [ Meals - Monday (Today) ]
            // breakfast =>
            System.Collections.Generic.List<Tuple<IFood, decimal>> tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            var yogurt = new Tuple<IFood, decimal>(food11, 2000);
            var quesoManchego = new Tuple<IFood, decimal>(food9, 2000);
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal0 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Lunes"
            };
            _mealsMpp.Save(meal0);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            var water = new Tuple<IFood, decimal>(food10, 2000);
            var carneCerdo = new Tuple<IFood, decimal>(food7, 2000);
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal1 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Lunes"
            };
            _mealsMpp.Save(meal1);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            var coffeWithMilk = new Tuple<IFood, decimal>(food13, 3);
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal2 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Lunes"
            };
            _mealsMpp.Save(meal2);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            var carnePicanha = new Tuple<IFood, decimal>(food6, 2000);
            var quesoBrie = new Tuple<IFood, decimal>(food8, 2300);
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal3 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Lunes"
            };
            _mealsMpp.Save(meal3);
            #endregion

            #region [ Meals - Sunday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal00 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Domingo",
                TimeStamp = DateTime.Now.AddDays(-1)
            };
            _mealsMpp.Save(meal00);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal01 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Domingo",
                TimeStamp = DateTime.Now.AddDays(-1)
            };
            _mealsMpp.Save(meal01);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal02 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Domingo",
                TimeStamp = DateTime.Now.AddDays(-1)
            };
            _mealsMpp.Save(meal02);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal03 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Domingo",
                TimeStamp = DateTime.Now.AddDays(-1)
            };
            _mealsMpp.Save(meal03);
            #endregion

            #region [ Meals - Saturday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal000 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Sabado",
                TimeStamp = DateTime.Now.AddDays(-2)
            };
            _mealsMpp.Save(meal000);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal001 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Sabado",
                TimeStamp = DateTime.Now.AddDays(-2)
            };
            _mealsMpp.Save(meal001);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal002 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Sabado",
                TimeStamp = DateTime.Now.AddDays(-2)
            };
            _mealsMpp.Save(meal002);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal003 = new BE.Meals {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Sabado",
                TimeStamp = DateTime.Now.AddDays(-2)
            };
            _mealsMpp.Save(meal003);
            #endregion

            #region [ Meals - Friday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal0000 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Viernes",
                TimeStamp = DateTime.Now.AddDays(-3)
            };
            _mealsMpp.Save(meal0000);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal0001 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Viernes",
                TimeStamp = DateTime.Now.AddDays(-3)
            };
            _mealsMpp.Save(meal0001);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal0002 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Viernes",
                TimeStamp = DateTime.Now.AddDays(-3)
            };
            _mealsMpp.Save(meal0002);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal0003 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Viernes",
                TimeStamp = DateTime.Now.AddDays(-3)
            };
            _mealsMpp.Save(meal0003);
            #endregion  

            #region [ Meals - Thursday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal00000 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Jueves",
                TimeStamp = DateTime.Now.AddDays(-4)
            };
            _mealsMpp.Save(meal00000);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal00001 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Jueves",
                TimeStamp = DateTime.Now.AddDays(-4)
            };
            _mealsMpp.Save(meal00001);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal00002 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Jueves",
                TimeStamp = DateTime.Now.AddDays(-4)
            };
            _mealsMpp.Save(meal00002);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal00003 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Jueves",
                TimeStamp = DateTime.Now.AddDays(-4)
            };
            _mealsMpp.Save(meal00003);
            #endregion

            #region [ Meals - Wednesday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal000000 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Miércoles",
                TimeStamp = DateTime.Now.AddDays(-5)
            };
            _mealsMpp.Save(meal000000);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal000001 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Miércoles",
                TimeStamp = DateTime.Now.AddDays(-5)
            };
            _mealsMpp.Save(meal000001);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            tuplesMeals.Add(coffeWithMilk);
            tuplesMeals.Add(coffeWithMilk);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal000002 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Miércoles",
                TimeStamp = DateTime.Now.AddDays(-5)
            };
            _mealsMpp.Save(meal000002);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(carnePicanha);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal000003 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Miércoles",
                TimeStamp = DateTime.Now.AddDays(-5)
            };
            _mealsMpp.Save(meal000003);
            #endregion

            #region [ Meals - Tuesday ]
            // breakfast =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(yogurt);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal0000000 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Desayuno,
                Description = "Desayuno_Martes",
                TimeStamp = DateTime.Now.AddDays(-6)
            };
            _mealsMpp.Save(meal0000000);

            // lunch =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoManchego);
            tuplesMeals.Add(quesoManchego);
            LifeTracker.Core.BE.Meals meal0000001 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Almuerzo,
                Description = "Almuerzo_Martes",
                TimeStamp = DateTime.Now.AddDays(-6)
            };
            _mealsMpp.Save(meal0000001);

            // tea time =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(coffeWithMilk);
            tuplesMeals.Add(coffeWithMilk);
            LifeTracker.Core.BE.Meals meal0000002 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Merienda,
                Description = "Merienda_Martes",
                TimeStamp = DateTime.Now.AddDays(-6)
            };
            _mealsMpp.Save(meal0000002);

            // dinner =>
            tuplesMeals = new System.Collections.Generic.List<Tuple<IFood, decimal>>();
            tuplesMeals.Add(water);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(carneCerdo);
            tuplesMeals.Add(quesoBrie);
            tuplesMeals.Add(carneCerdo);
            LifeTracker.Core.BE.Meals meal0000003 = new BE.Meals
            {
                Portion = tuplesMeals,
                Type = Interfaces.Type.Cena,
                Description = "Cena_Martes",
                TimeStamp = DateTime.Now.AddDays(-6)
            };
            _mealsMpp.Save(meal0000003);
            #endregion
        }

        #region [ Other Methods ]
        public List<IMeals> GetAll() {
            var meals = _mealsMpp.GetAll();
            var mealsBE = (List<IMeals>)meals;
            return mealsBE;
        }
        #endregion

        #region [ Chart Data ]
        public decimal GetAllTodaysFat() {
            var meals = _mealsMpp.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            decimal fat = 0;
            foreach(var meal in meals) {
                foreach(var portion in meal.Portion) 
                    fat += portion.Item1.Fat;
            }
            return fat;
        }
        
        public decimal GetAllTodaysProtein() {
            var meals = _mealsMpp.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            decimal protein = 0;
            foreach (var meal in meals) {
                foreach (var portion in meal.Portion)
                    protein += portion.Item1.Protein;
            }
            return protein;
        }

        public decimal GetAllTodaysCalories() {
            var meals = _mealsMpp.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            decimal calories = 0;
            foreach (var meal in meals) {
                foreach (var portion in meal.Portion)
                    calories += portion.Item1.Calories;
            }
            return calories;
        }

        public List<double> GetAllTodaysMeals() {
            // Breakfast / Lunch / Tea / Dinner (set in that order)
            var meals = _mealsMpp.GetAll().Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            double breakfast = 0;
            double lunch = 0;
            double tea = 0;
            double dinner = 0;

            foreach (var meal in meals) {
                if (meal.Type == Type.Desayuno)
                    breakfast += 1;
                else if (meal.Type == Type.Almuerzo)
                    lunch += 1;
                else if (meal.Type == Type.Merienda)
                    tea += 1;
                else if (meal.Type == Type.Cena)
                    dinner += 1;
            }
            // sum of total meals
            double sumOfMeals = breakfast + lunch + tea + dinner;
            var breakfastPer = (breakfast / sumOfMeals) * 100;
            var lunchPer = (lunch / sumOfMeals) * 100;
            var teaPer = (tea / sumOfMeals) * 100;
            var dinnerPer = (dinner / sumOfMeals) * 100;

            return new List<double>() { breakfastPer, lunchPer, teaPer, dinnerPer };
        }

        public List<double> GetAllDatesOfWeek() {
            var meals = _mealsMpp.GetAll().ToList();
            var mealsMonday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).ToList();
            var mealsSunday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy")).ToList();
            var mealsSaturday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy")).ToList();
            var mealsFriday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy")).ToList();
            var mealsThrusday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")).ToList();
            var mealsWednesday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-5).ToString("MM/dd/yyyy")).ToList();
            var mealsTuesday = meals.Where(x => x.TimeStamp.ToString("MM/dd/yyyy") == DateTime.Now.AddDays(-6).ToString("MM/dd/yyyy")).ToList();

            // Monday
            decimal caloriesMonday = 0;
            foreach (var meal in mealsMonday) {
                foreach (var portion in meal.Portion)
                    caloriesMonday += portion.Item1.Calories;
            }

            // Sunday
            decimal caloriesSunday = 0;
            foreach (var meal in mealsSunday) {
                foreach (var portion in meal.Portion)
                    caloriesSunday += portion.Item1.Calories;
            }

            // Saturday
            decimal caloriesSaturday = 0;
            foreach (var meal in mealsSaturday) {
                foreach (var portion in meal.Portion)
                    caloriesSaturday += portion.Item1.Calories;
            }

            // Friday
            decimal caloriesFriday = 0;
            foreach (var meal in mealsFriday) {
                foreach (var portion in meal.Portion)
                    caloriesFriday += portion.Item1.Calories;
            }

            // Thrusday
            decimal caloriesThrusday = 0;
            foreach (var meal in mealsThrusday) {
                foreach (var portion in meal.Portion)
                    caloriesThrusday += portion.Item1.Calories;
            }

            // Wednesday
            decimal caloriesWednesday = 0;
            foreach (var meal in mealsWednesday) {
                foreach (var portion in meal.Portion)
                    caloriesWednesday += portion.Item1.Calories;
            }

            // Tuesday
            decimal caloriesTuesday = 0;
            foreach (var meal in mealsTuesday) {
                foreach (var portion in meal.Portion)
                    caloriesTuesday += portion.Item1.Calories;
            }

            return new List<double>() {
                Convert.ToDouble(caloriesTuesday),
                Convert.ToDouble(caloriesWednesday),
                Convert.ToDouble(caloriesThrusday),
                Convert.ToDouble(caloriesFriday),
                Convert.ToDouble(caloriesSaturday),
                Convert.ToDouble(caloriesSunday),
                Convert.ToDouble(caloriesMonday) };
        }
        #endregion

        #region [ Diet ]
        public decimal CalculateNutritionalDiet(User user, List<IMeals> meals) {
            if (user.DietCount == 0)
                return 0.0m;

            return Math.Round(Convert.ToDecimal((user.DietCount / meals.Count) * 100), 1);
        }
        #endregion

        #region [ Objective ]
        public decimal CalculateObjective(User user) {
            decimal objective_pct = 0;

            switch (user.Objective) {
                case Core.Interfaces.Objective.None:
                    objective_pct = 0.0m;
                    break;
                case Core.Interfaces.Objective.Increase_Weight:
                    objective_pct = (user.DietCount > 0 ? 100.0m : 0.0m);
                    break;
                case Core.Interfaces.Objective.Decrease_Weight:
                    objective_pct = (user.DietCount > 0 ? 100.0m : 0.0m);
                    break;
                case Core.Interfaces.Objective.Keep_Same_Weight:
                    objective_pct = (user.DietCount > 0 ? 100.0m : 0.0m);
                    break;
                case Core.Interfaces.Objective.Load_Meals:
                    objective_pct = (user.DietCount > 0 ? 100.0m : 0.0m);
                    break;
                default:
                    break;
            }
            return objective_pct;
        }
        #endregion

    }
}
