using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class Meal
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Instructions { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
