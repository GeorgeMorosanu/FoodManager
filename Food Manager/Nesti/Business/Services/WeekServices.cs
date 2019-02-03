using Nesti.Business.Interfaces;
using Nesti.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data;

namespace Nesti.Business.Services
{
    public class WeekServices : IWeekServices
    {
        private readonly NsContext _databaseNsContext;

        public List<Ingredient> getIngredientsForTheWeek()
        {
            var result = new List<Ingredient>();

            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsMonday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsTuesday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsWednesday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsThursday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsFriday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsSaturday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            foreach (var meal in _databaseNsContext.Weeks.ToList()[0].MealsMonday.ToList())
            {
                foreach (var ing in meal.Ingredients)
                {
                    result.Add(ing);
                }
            }
            throw new NotImplementedException();
        }
    }
}
