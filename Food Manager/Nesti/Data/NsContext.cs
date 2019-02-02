using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Nesti.Data.Entities;

namespace Nesti.Data
{
    public class NsContext : DbContext {
     
        public NsContext(DbContextOptions<NsContext> options) : base (options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
