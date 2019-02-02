using System;
using System.ComponentModel.DataAnnotations;

namespace Nesti.Data.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int Barcode { get; set; }
        public double Price { get; set; }

    }
}
