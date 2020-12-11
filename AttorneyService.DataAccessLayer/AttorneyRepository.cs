using Microsoft.EntityFrameworkCore;
using Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttorneyService.DataAccessLayer
{
    public class AttorneyRepository : IAttorneyRepository
    {
        private readonly AtorneyDbContext atorneyDbContext;
        public AttorneyRepository(AtorneyDbContext atorneyDbContext)
        {
            this.atorneyDbContext = atorneyDbContext;
        }

        public AttorneyEntities Add(AttorneyEntities atr)
        {
            
            atorneyDbContext.Attorneys.Add(atr);
            atorneyDbContext.Address.Add(atr.AddressEntities);
            atorneyDbContext.SaveChanges();
            return atr;
        }

        public List<AttorneyEntities> GetAttorneys()
        {
            //List<AttorneyEntities> attorney=new List<AttorneyEntities>();

            //foreach(var row in atorneyDbContext.Attorneys) {
            //    attorney.Add(row);

            //}
            var obj = atorneyDbContext.Attorneys.Include("AddressEntities").ToList();
            var obj1 = from e in atorneyDbContext.Attorneys
                       select e;
            //return (List<AttorneyEntities>)obj1;
            return obj;
        }

        public AttorneyEntities Delete(AttorneyEntities atr)
        {

            atorneyDbContext.Attorneys.Update(atr);
            atorneyDbContext.SaveChanges();
            return atr;
        }

        //public AttorneyEntities Update(AttorneyEntities atr)
        //{

        //    atorneyDbContext.Attorneys.Add(atr);
        //    atorneyDbContext.Address.Add(atr.AddressEntities);
        //    atorneyDbContext.SaveChanges();
        //    return atr;
        //}

    }
}
