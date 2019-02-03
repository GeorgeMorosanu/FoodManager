using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IWeekServices
    {
        List<Ingredient> getIngredientsForTheWeek();

        void AddAMealForMonday(Meal meal);
        void RemoveAMealForMonday(Meal meal);

        void AddAMealForTuesday(Meal meal);
        void RemoveAMealForTuesday(Meal meal);

        void AddAMealForWednesday(Meal meal);
        void RemoveAMealForWednesday(Meal meal);

        void AddAMealForThursday(Meal meal);
        void RemoveAMealForThursday(Meal meal);

        void AddAMealForFriday(Meal meal);
        void RemoveAMealForFriday(Meal meal);

        void AddAMealForSaturday(Meal meal);
        void RemoveAMealForSaturday(Meal meal);

        void AddAMealForSunday(Meal meal);
        void RemoveAMealForSunday(Meal meal);
    }
}
