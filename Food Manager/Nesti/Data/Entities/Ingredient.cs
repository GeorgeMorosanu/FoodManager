using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }
        public virtual GenericProduct GenericProduct { get; set; }
        public virtual int Amount { get; set; }
    }
}
