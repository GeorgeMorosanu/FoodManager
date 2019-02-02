using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data.Entities
{
    public class GenericProduct
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Measurement Measurement { get; set; }
    }
}
