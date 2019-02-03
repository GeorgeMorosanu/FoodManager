using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Business.Interfaces;
using Nesti.Data;
using Nesti.Data.Entities;

namespace Nesti.Business.Services
{
    public class IngredientSerices : IIngredientSerices
    {
        private readonly NsContext _databaseNsContext;

        public IngredientSerices(NsContext databaseNsContext)
        {
            _databaseNsContext = databaseNsContext;
        }

        public void Create(Ingredient ing)
        {
            _databaseNsContext.Ingredients.Add(ing);

            _databaseNsContext.SaveChanges();
        }

        public void Delete(Ingredient ing)
        {
            _databaseNsContext.Ingredients.Remove(ing);

            _databaseNsContext.SaveChanges();
        }

        public void Edit(Ingredient ing)
        {
            var choosenIng = _databaseNsContext.Ingredients.Where(x => x.Id == ing.Id).First();

            choosenIng.Amount = ing.Amount;
            choosenIng.GenericProduct = ing.GenericProduct;

            _databaseNsContext.Ingredients.Update(choosenIng);

            _databaseNsContext.SaveChanges();
        }

        public bool Exists(Guid id)
        {
            return _databaseNsContext.Ingredients.Any(ing => ing.Id == id);
        }

        public List<Ingredient> GetAll()
        {
            return _databaseNsContext.Ingredients.ToList();
        }
    }
}
