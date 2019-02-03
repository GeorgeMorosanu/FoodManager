using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IWeekServices
    {
        List<Ingredient> getIngredientsForTheWeek();
    }
}
