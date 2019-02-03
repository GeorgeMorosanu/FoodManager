using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IMealServices
    {
        List<Meal> GetAll();
        void Create(Meal meal);
        void Edit(Meal meal);
        void Delete(Meal meal);
        bool Exists(Guid id);
    }
}
