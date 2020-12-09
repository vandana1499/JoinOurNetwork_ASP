using Modal;
using System;
using System.Collections.Generic;
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
        public Attorney Add(Attorney atr)
        {
            atorneyDbContext.Attorneys.Add(atr);
            atorneyDbContext.SaveChanges();
            return atr;
        }
    }
}
