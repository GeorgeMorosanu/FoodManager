using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IIngredientSerices
    {
        List<Ingredient> GetAll();
        void Create(Ingredient ing);
        void Edit(Ingredient ing);
        void Delete(Ingredient ing);
        bool Exists(Guid id);
    }
}
