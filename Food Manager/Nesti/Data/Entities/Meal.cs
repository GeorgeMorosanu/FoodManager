using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class Meal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Instructions { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual ICollection<WeekMeal> WeekMeals { get; set; }

    }
}
