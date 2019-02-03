using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Business.Interfaces;
using Nesti.Data;
using Nesti.Data.Entities;

namespace Nesti.Business.Services
{
    public class MealServices : IMealServices
    {
        private readonly NsContext _databaseNsContext;

        public void Create(Meal meal)
        {
            _databaseNsContext.Meals.Add(meal);

            _databaseNsContext.SaveChanges();
        }

        public void Delete(Meal meal)
        {
            _databaseNsContext.Meals.Remove(meal);

            _databaseNsContext.SaveChanges();
        }

        public void Edit(Meal meal)
        {
            var choosenMeal = _databaseNsContext.Meals.Where(x => x.Id == meal.Id).First();

            choosenMeal.Name = meal.Name;
            choosenMeal.Ingredients = meal.Ingredients;
            choosenMeal.Instructions = meal.Instructions;
            choosenMeal.PreparationTime = meal.PreparationTime;

            _databaseNsContext.Meals.Update(choosenMeal);

            _databaseNsContext.SaveChanges();
        }

        public bool Exists(Guid id)
        {
            return _databaseNsContext.Meals.Any(meal => meal.Id == id);
        }

        public List<Meal> GetAll()
        {
            return _databaseNsContext.Meals.ToList();
        }

        public List<Meal> searchMealByName(string name)
        {
            return _databaseNsContext.Meals.Where(x=>x.Name.Contains(name)).ToList();
        }
    }
}
