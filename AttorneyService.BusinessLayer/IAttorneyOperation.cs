using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.BusinessLayer
{
    public interface IAttorneyOperation
    {
        string createProfile(Attorney atr);
        List<Attorney> getAllProfiles();

        //Attorney editProfile(int id, Attorney ATSObj);
    }
}
