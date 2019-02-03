using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class WeekMeal
    {
        public Guid WeekId { get; set; }
        public virtual Week Week { get; set; }
        public Guid MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public int Day { get; set; } // 0 - monday; 6 - sunday

    }
}
