using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using System;
using System.Configuration;
using System.Collections.Generic;
using LifeTracker.DataAccess.Mapper.DTO;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper
{
    public class Food : ICrud<IFood> {

        protected IList<IFood> dataContext = new List<IFood>();
        protected string xmlDb;

        public Food() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] +"Foods.xml";
    }

        public void Delete(IFood entity) {
            throw new NotImplementedException();
        }

        public IList<IFood> GetAll() {
            var foods = XmlSerializationFood.GetAll(xmlDb);
            dataContext = new List<IFood>();    // fresh data for dataContext

            foreach (var food in foods) {
                var food1 = new LifeTracker.Core.BE.Food() {
                    FoodId = Guid.Parse(food[0]),
                    Name = food[1],
                    Description = food[2],
                    Carbohydrates = Convert.ToDecimal(food[3]),
                    Protein = Convert.ToDecimal(food[4]),
                    Fat = Convert.ToDecimal(food[5]),
                    Vitamin = Convert.ToDecimal(food[6]),
                    Mineral = Convert.ToDecimal(food[7]),
                    Fibre = Convert.ToDecimal(food[8]),
                    Water = Convert.ToDecimal(food[9]),
                    Calories = Convert.ToDecimal(food[10]),
                    Quantity = Convert.ToDecimal(food[11])
                };
                dataContext.Add(food1);
            }
            return dataContext;
        }

        public IList<IFood> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public IFood GetId(Guid id) {
            throw new NotImplementedException();
        }

        public void Save(IFood entity) {
            var exists = XmlSerializationFood.Exists(xmlDb, entity.Description.ToString());

            if (!exists) {
                string[,] entries = new string[,] {
                    { "foodId", entity.Id.ToString() },
                    { "name", entity.Name },
                    { "description", entity.Description },
                    { "carbohydrates", entity.Carbohydrates.ToString() },
                    { "protein", entity.Protein.ToString() },
                    { "fat", entity.Fat.ToString() },
                    { "vitamin", entity.Vitamin.ToString() },
                    { "mineral", entity.Mineral.ToString() },
                    { "fibre", entity.Fibre.ToString() },
                    { "water", entity.Water.ToString() },
                    { "calories", entity.Calories.ToString() },
                    { "quantity", entity.Quantity.ToString() },
                    { "timestamp", DateTime.Now.ToString() }
                };

                XmlSerializationFood.SerializeNode(xmlDb, entries);
            }
        }

    }
}
