using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.DataAccessLayer
{
   public interface IAttorneyRepository
    {
        AttorneyEntities Add(AttorneyEntities atr);
        List<AttorneyEntities> GetAttorneys();

        AttorneyEntities Delete(AttorneyEntities atr);
         void update(AttorneyPUT atr, int id);
    }
}
