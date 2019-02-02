using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class Week
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Meal> MealsMonday { get; set; }
        public virtual List<Meal> MealsTuesday { get; set; }
        public virtual List<Meal> MealsWednesday { get; set; }
        public virtual List<Meal> MealsThursday { get; set; }
        public virtual List<Meal> MealsFriday { get; set; }
        public virtual List<Meal> MealsSaturday { get; set; }
        public virtual List<Meal> MealsSunday { get; set; }

    }
}
