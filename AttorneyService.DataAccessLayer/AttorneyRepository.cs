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
            var obj = atorneyDbContext.Attorneys.AsNoTracking().Include("AddressEntities").AsNoTracking().ToList();
            var obj1 = from e in atorneyDbContext.Attorneys
                       select e;
           
            return obj1.ToList();
           // return obj;
        }

        public AttorneyEntities Delete(AttorneyEntities atr)
        {

            atorneyDbContext.Attorneys.Update(atr);
            atorneyDbContext.SaveChanges();
            return atr;
        }

        public void update(AttorneyPUT atr,int id)
        {
            //tracking
            var attorney = atorneyDbContext.Attorneys.FirstOrDefault(e=>e.id==id);
            //var attorney = new AttorneyEntities();
            attorney.FirstName = atr.FirstName;
            attorney.LastName = atr.LastName;
            attorney.MiddleName = atr.MiddleName;
            attorney.Specialization = (specialization)atr.Specialization;
            attorney.AddressEntities.City=atr.Address.City;
            attorney.AddressEntities.Lane1 = atr.Address.Lane1;
            attorney.AddressEntities.Lane2 = atr.Address.Lane2;
            attorney.AddressEntities.Zip = atr.Address.Zip;
            attorney.AddressEntities.State = atr.Address.State;
    

            //attorney.id = id;
            //atorneyDbContext.Entry(attorney).State = EntityState.Modified;
            atorneyDbContext.SaveChanges();
            

        }

    }
}


//FirstName = atr.FirstName,
//                LastName = atr.LastName,
//                MiddleName = atr.MiddleName,
//                Specialization = (specialization)atr.Specialization,
//                Address = atr.Address != null ? new Address {
//                    City = atr.Address.City,
//                    Lane1 = atr.Address.Lane1,
//                    Lane2 = atr.Address.Lane2,
//                    State = atr.Address.State,
//                    Zip = atr.Address.Zip
//                } : null

