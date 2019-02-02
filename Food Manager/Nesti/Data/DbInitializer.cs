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

            foreach(string n in names)
            {
                var gp = new GenericProduct
                {
                    Name = n,
                    Measurement = measurements[index]
                };
                context.Add(gp);
                index++;
            }

            context.SaveChanges();

            // products 

            index = 0;
            Random rnd = new Random();

            var prod = new Product()
            {
                Name = "Black Canyon",
                Barcode = rnd.Next(1, 100),
                Price = rnd.Next(100, 7000),
                GenericProduct = context.GenericProducts.Where(x=>x.Name== "Ground beef").First()
            };
            context.Add(prod);

            names = new List<string> { "Thousand Hills", "Lusk", "Monterey", "Hunts", "Kraft", "Happy", "Barilla" };

            foreach (string n in names)
            {
                var p = new Product
                {
                    Name = n,
                    Barcode = rnd.Next(1, 100),
                    Price = rnd.Next(100, 7000),
                    GenericProduct = context.GenericProducts.ToList()[index]
                };

                context.Add(p);
                index++;
            }
            
            context.SaveChanges();

            //ingredients

            //meal

            index = 0;

            names = new List<string> { "Lasagna", "Fish" };
            
            var meal_Lasagna = new Meal()
            {
                Name = names[0],
                PreparationTime = rnd.Next(20,120),
                Instructions = "Preheat oven to 350 degrees F (175 degrees C).\n"+
                "In a large skillet,\n"+
                "cook and stir ground beef until brown.Add mushrooms and onions; saute until onions are transparent.Stir in pasta sauce, and heat through.\n" +
                "In a medium size bowl, combine cottage cheese, ricotta cheese, grated Parmesan cheese, and eggs.\n" +
                "Spread a thin layer of the meat sauce in the bottom of a 13x9 inch pan.Layer with uncooked lasagna noodles, cheese mixture, mozzarella cheese, and meat sauce.Continue layering until all ingredients are used, reserving 1 / 2 cup mozzarella. Cover pan with aluminum foil.\n" +
                "Bake in preheated oven for 45 minutes.Uncover, and top with remaining half cup of mozzarella cheese.Bake for an additional 15 minutes.Remove from oven, and let stand 10 to 15 minutes before serving.",
                Ingredients = new List<Ingredient>() { }
            };

            //week
        }

    }
}
