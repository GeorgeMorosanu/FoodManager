using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IWeekServices
    {
        List<Week> getWeek();
        List<Ingredient> getIngredientsForTheWeek();

        List<Meal> getMealsForMonday();
        List<Meal> getMealsForTuesday();
        List<Meal> getMealsForWednsday();
        List<Meal> getMealsForThursday();
        List<Meal> getMealsForFriday();
        List<Meal> getMealsForSaturday();
        List<Meal> getMealsForSunday();
    }
}
