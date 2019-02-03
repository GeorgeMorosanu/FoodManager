using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Data.Entities;

namespace Nesti.Business.Interfaces
{
    public interface IGenericProuctServices
    {
        List<GenericProduct> GetAll();
        void Create(GenericProduct gp);
        void Edit(GenericProduct gp);
        void Delete(GenericProduct gp);
        bool Exists(Guid id);
    }
}
