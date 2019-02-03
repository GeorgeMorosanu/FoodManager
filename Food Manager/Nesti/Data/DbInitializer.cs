using Nesti.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

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

            index = 0;

            var ing0 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[0],
                Amount = 450
            };
            context.Add(ing0);

            var ing1 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[1],
                Amount = 50
            };
            context.Add(ing1);

            var ing2 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[2],
                Amount = 100
            };
            context.Add(ing2);

            var ing3 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[3],
                Amount = 800
            };
            context.Add(ing3);

            var ing4 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[4],
                Amount = 650
            };
            context.Add(ing4);

            var ing5 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[5],
                Amount = 2
            };
            context.Add(ing5);

            var ing6 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[6],
                Amount = 450
            };
            context.Add(ing6);

            var ing7 = new Ingredient()
            {
                GenericProduct = context.GenericProducts.ToList()[4],
                Amount = 100
            };
            context.Add(ing7);

            context.SaveChanges();

            //meal

            index = 0;

            names = new List<string> { "Lasagna", "French omelet" };
            
            var meal_Lasagna = new Meal()
            {
                Id = new Guid(),
                Name = names[0],
                PreparationTime = rnd.Next(20,120),
                Instructions = "Preheat oven to 350 degrees F (175 degrees C).\n" +
                "In a large skillet,\n" +
                "cook and stir ground beef until brown.Add mushrooms and onions; saute until onions are transparent.Stir in pasta sauce, and heat through.\n" +
                "In a medium size bowl, combine cottage cheese, ricotta cheese, grated Parmesan cheese, and eggs.\n" +
                "Spread a thin layer of the meat sauce in the bottom of a 13x9 inch pan.Layer with uncooked lasagna noodles, cheese mixture, mozzarella cheese, and meat sauce.Continue layering until all ingredients are used, reserving 1 / 2 cup mozzarella. Cover pan with aluminum foil.\n" +
                "Bake in preheated oven for 45 minutes.Uncover, and top with remaining half cup of mozzarella cheese.Bake for an additional 15 minutes.Remove from oven, and let stand 10 to 15 minutes before serving.",
                Ingredients = new List<Ingredient>() { ing0,ing1,ing2,ing3,ing4,ing5,ing6}
            };
            context.Add(meal_Lasagna);

            var meal_Omelet = new Meal()
            {
                Id = new Guid(),
                Name = names[1],
                PreparationTime = rnd.Next(7, 10),
                Instructions = "BEAT eggs, 2 tbsp of water, 1/8 tsp of salt and a dash of pepper in small bowl until blended.\n" +
                "HEAT 1 tsp of butter in 6 to 8-inch nonstick omelet pan or skillet over medium - high heat until hot.TILT pan to coat bottom.POUR IN egg mixture.Mixture should set immediately at edges.\n" +
                "GENTLY PUSH cooked portions from edges toward the center with inverted turner so that uncooked eggs can reach the hot pan surface.CONTINUE cooking,\n" +
                "tilting pan and gently moving cooked portions as needed.\n" +
                "When top surface of eggs is thickened and no visible liquid egg remains,\n" +
                "PLACE the mozzarella on one side of the omelet.FOLD omelet in half with turner.With a quick flip of the wrist,\n" +
                "turn pan and INVERT or SLIDE omelet onto plate.SERVE immediately.\n",
                Ingredients = new List<Ingredient>() { ing5, ing7 }
            };
            context.Add(meal_Omelet);

            var normal_eggs = new Meal()
            {
                Id = new Guid(),
                Name = "Eggs",
                PreparationTime = rnd.Next(7, 10),
                Instructions = "Only for the sake of having more meals.",
                Ingredients = new List<Ingredient>() { ing5 }
            };
            context.Add(normal_eggs);

            context.SaveChanges();

            //week
            
            var week1 = new Week()
            {
                Id = new Guid(),
                StartDate = new DateTime(2019, 2, 4),
                EndDate = new DateTime(2019, 2, 10)
            };
            context.Add(week1);
            context.SaveChanges();

            //var week1 = new Week()
            //{
            //    StartDate = new DateTime(2019, 2, 4),
            //    EndDate = new DateTime(2019, 2, 10),
            //    MealsMonday = new List<Meal>() { meal_Lasagna },
            //    MealsTuesday = new List<Meal>() { normal_eggs },
            //    MealsWednesday = new List<Meal>() { meal_Lasagna },
            //    MealsThursday = new List<Meal>() { meal_Omelet },
            //    MealsFriday = new List<Meal>() { meal_Lasagna },
            //    MealsSaturday = new List<Meal>() { meal_Omelet },
            //    MealsSunday = new List<Meal>() { normal_eggs }
            //};
            //context.Add(week1);

            //context.SaveChanges();

            var wid = context.weeks.asnotracking().first().id.tostring();
            console.writeline(wid);

            /*
            WeekMeal wMon = new WeekMeal()
            {
                WeekId = context.Weeks.AsNoTracking().First().Id,
                MealId = context.Meals.AsNoTracking().First(m => m.Name == "Lasagna").Id,
                Day = 0
            };
            context.Add(wMon);


            WeekMeal wMonTwo = new WeekMeal()
            {
                WeekId = context.Weeks.AsNoTracking().First().Id,
                MealId = context.Meals.AsNoTracking().FirstOrDefault(m => m.Name == "Eggs").Id,
                Day = 0
            };
            context.Add(wMonTwo);
            

            WeekMeal wTue = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "Eggs").Id,
                Day = 1
            };
            context.Add(wTue);

            WeekMeal wWed = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "French omelet").Id,
                Day = 2
            };
            context.Add(wWed);

            WeekMeal wThu = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "Lasagna").Id,
                Day = 3
            };
            context.Add(wThu);

            WeekMeal wFri = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "French omelet").Id,
                Day = 4
            };
            context.Add(wFri);

            WeekMeal wSat = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "Eggs").Id,
                Day = 5
            };
            context.Add(wSat);

            WeekMeal wSun = new WeekMeal()
            {
                WeekId = context.Weeks.First().Id,
                MealId= context.Meals.FirstOrDefault(m => m.Name == "Eggs").Id,
                Day = 6
            };
            context.Add(wSun);
            
    */

            context.SaveChanges();
        }

    }
}
