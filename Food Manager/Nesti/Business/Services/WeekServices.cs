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
        
        public WeekServices(NsContext databaseNsContext)
        {
            _databaseNsContext = databaseNsContext;
        }
        
    
        public List<Meal> getMealsForFriday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                    join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                    where weekmeal.Day==4
                    select meal).ToList();
            
        }

        public List<Meal> getMealsForMonday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 0
                select meal).ToList();
        }

        public List<Meal> getMealsForSaturday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 5
                select meal).ToList();
        }

        public List<Meal> getMealsForSunday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 6
                select meal).ToList();
        }

        public List<Meal> getMealsForThursday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 3
                select meal).ToList();
        }

        public List<Meal> getMealsForTuesday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 1
                select meal).ToList();
        }

        public List<Meal> getMealsForWednsday()
        {
            return (from weekmeal in _databaseNsContext.WeekMeals
                join meal in _databaseNsContext.Meals on weekmeal.MealId equals meal.Id
                where weekmeal.Day == 2
                select meal).ToList();
        }

        public List<Week> getWeek()
        {
            return _databaseNsContext.Weeks.ToList();
        }

        public List<Ingredient> getIngredientsForTheWeek()
        {
            var result = new List<Ingredient>();

            foreach (var meal in getMealsForMonday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }
            foreach (var meal in getMealsForTuesday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }

            foreach (var meal in getMealsForWednsday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }

            foreach (var meal in getMealsForThursday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }

            foreach (var meal in getMealsForFriday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }

            foreach (var meal in getMealsForSaturday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }

            foreach (var meal in getMealsForSunday())
            {
                foreach (var ing in meal.Ingredients)
                {
                    var ok = 1;
                    foreach (var res in result)
                    {
                        if (ing.GenericProduct == res.GenericProduct)
                        {
                            ok = 0;
                        }
                    }

                    if (ok == 1)
                    {
                        result.Add(ing);
                    }
                }
            }
            return result;
        }
    }
}
