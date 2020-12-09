using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.DataAccessLayer
{
   public interface IAttorneyRepository
    {
        Attorney Add(Attorney atr);
       
    }
}
