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
        
        public void AddAMealForFriday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsFriday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForMonday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsMonday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForSaturday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsSaturday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForSunday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsSunday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForThursday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsThursday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForTuesday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsTuesday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void AddAMealForWednesday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsWednesday.Add(meal);
            //_databaseNsContext.SaveChanges();
        }

        public List<Ingredient> getIngredientsForTheWeek()
        {
            var result = new List<Ingredient>();
            /*
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
            } */

            return result;
        }

        public List<Week> getWeek()
        {
            return _databaseNsContext.Weeks.ToList();
        }

        public void RemoveAMealForFriday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsFriday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForMonday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsMonday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForSaturday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsSaturday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForSunday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsSunday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForThursday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsThursday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForTuesday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsTuesday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }

        public void RemoveAMealForWednesday(Meal meal)
        {
            //_databaseNsContext.Weeks.ToList()[0].MealsWednesday.Remove(meal);
            //_databaseNsContext.SaveChanges();
        }
        
    }
}
