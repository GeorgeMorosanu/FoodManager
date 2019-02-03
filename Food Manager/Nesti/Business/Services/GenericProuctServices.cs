using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nesti.Business.Interfaces;
using Nesti.Data;
using Nesti.Data.Entities;

namespace Nesti.Business.Services
{
    public class GenericProuctServices : IGenericProuctServices
    {
        private readonly NsContext _databaseNsContext;

        public GenericProuctServices(NsContext databaseNsContext)
        {
            _databaseNsContext= databaseNsContext
        }

        public void Create(GenericProduct gp)
        {
            _databaseNsContext.GenericProducts.Add(gp);

            _databaseNsContext.SaveChanges();
        }

        public void Delete(GenericProduct gp)
        {
            _databaseNsContext.GenericProducts.Remove(gp);

            _databaseNsContext.SaveChanges();
        }

        public void Edit(GenericProduct gp)
        {
            var choosenGp = _databaseNsContext.GenericProducts.Where(x => x.Id == gp.Id).First();
            choosenGp.Measurement = gp.Measurement;
            choosenGp.Name = gp.Name;

            _databaseNsContext.GenericProducts.Update(choosenGp);

            _databaseNsContext.SaveChanges();

        }

        public bool Exists(Guid id)
        {
            return _databaseNsContext.GenericProducts.Any(gp => gp.Id == id);
        }

        public List<GenericProduct> GetAll()
        {
            return _databaseNsContext.GenericProducts.ToList();
        }
        
    }
}
