using Nesti.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesti.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NsContext context)
        {
            context.Database.EnsureCreated();

            if(context.Measurements.Any())
            {
                return;
            }

            // measurements

            var names = new List<string> { "piece", "gram", "liter" };
            var shortNames = new List<string> { "pc", "gr", "l" };
            int index = 0;

            foreach(string s in names)
            {
                var m = new Measurement
                {
                    Name = names[index],
                    ShortName = shortNames[index]
                };

                context.Add(m);
                index++;
            }

            context.SaveChanges();

            // generic products

            index = 0;

            names = new List<string> { "Ground beef", "Onion", "Mushrooms", "Tomato paste", "Mozzarella cheese", "Eggs", "Lasagna noodles" };

            var gram = context.Measurements.Where(x => x.ShortName == "gr").First();
            var piece = context.Measurements.Where(x => x.ShortName == "pc").First();

            var measurements = new List<Measurement> { gram, gram, gram, gram, gram, piece, gram };

            foreach(string s in names)
            {
                var gp = new GenericProduct
                {
                    Name = names[index],
                    Measurement = measurements[index]
                };
                context.Add(gp);
                index++;
            }

            index = 0;

            // products 

            





            context.SaveChanges();
        }

    }
}
