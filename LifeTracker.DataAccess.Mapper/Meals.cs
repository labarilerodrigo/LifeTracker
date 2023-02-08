using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using LifeTracker.DataAccess.Mapper.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Type = LifeTracker.Core.Interfaces.Type;

namespace LifeTracker.DataAccess.Mapper {

    public class Meals : ICrud<IMeals> {

        protected IList<IMeals> dataContext = new List<IMeals>();
        protected string xmlDb;

        public Meals() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] + "Meals.xml";
        }

        public void Delete(IMeals entity) {
            //var exists = XmlSerializationMeals.Exists(xmlDb, entity.Id.ToString()); 
            //if (exists) {
            //    dataContext = new List<LifeTracker.Core.BE.Meals>();    // fresh data for dataContext
            //    XmlSerializationMeals.RemoveNode(xmlDb, entity.User.Id.ToString());
            //    GetAll();
            //}
        }

        public IList<IMeals> GetAll() {
            var listOfmeals = XmlSerializationMeals.GetAll(xmlDb);
            Food _foodsMpp = new Food();

            dataContext = new List<IMeals>();    // fresh data for dataContext
            foreach (var meals in listOfmeals) {
                var listOfFoods = new List<Tuple<IFood, decimal>>();
                var mealsId = meals[0].Item2;
                var mealsType = meals[1].Item2;
                var mealsDescription = meals[2].Item2;
                var timestamp = meals[3].Item2;

                foreach (var foodId in meals[4].Item3) {
                    var food1 = (LifeTracker.Core.BE.Food)_foodsMpp.GetAll().Where(x => x.FoodId.ToString() == foodId).FirstOrDefault();
                    var food2 = new Tuple<IFood, decimal>(food1, 279);
                    listOfFoods.Add(food2);
                }
                LifeTracker.Core.BE.Meals meals1 = new LifeTracker.Core.BE.Meals {
                    MealsId = Guid.Parse(mealsId),
                    Type = (Type)Enum.Parse(typeof(Type), mealsType),
                    Description = mealsDescription,
                    TimeStamp = Convert.ToDateTime(timestamp),
                    Portion = listOfFoods
                };
            dataContext.Add((IMeals)meals1);
            }
            return dataContext;
        }

        public IList<IMeals> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public IMeals GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(IMeals entity) {
            var exists = XmlSerializationMeals.Exists(xmlDb, entity.Description.ToString());

            if (!exists) {                
                var tupleListOfPermissions = new List<string>();
                entity.Portion.ToList().ForEach(x => { tupleListOfPermissions.Add(x.Item1.Id.ToString()); });

                var mealsWithFood = new List<Tuple<string, string, List<string>>> {
                    new Tuple<string, string, List<string>>("mealsId", entity.Id.ToString(), null),
                    new Tuple<string, string, List<string>>("mealsType", entity.Type.ToString(), null),
                    new Tuple<string, string, List<string>>("mealsDescription", entity.Description, null),
                    new Tuple<string, string, List<string>>("timestamp", entity.TimeStamp.ToString(), null),
                    new Tuple<string, string, List<string>>("foods", "foodId", tupleListOfPermissions) };

                XmlSerializationMeals.SerializeNode(xmlDb, mealsWithFood);
            }
            //else {
            //    var user = GetId(entity.Id);
            //    if (user != null) {
            //        if (entity.Portion.Count != entity.Portion.Count) {
            //            // rebuild all user custom services
            //            Delete(user);
            //            Save(entity);
            //        }
            //    }
            //}
        }
    }

} 
