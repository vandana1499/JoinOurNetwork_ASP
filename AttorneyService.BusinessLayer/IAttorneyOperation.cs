using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.BusinessLayer
{
    public interface IAttorneyOperation
    {
        Attorney createProfile(Attorney atr);
        //Attorney updateProfileByID(Attorney atr, int id);
        List<Attorney> getAllProfiles();
        List<Attorney> getAllProfilesByCity(string city);
        List<string> getAllProfilesByDistinctCity();
        void DeleteProfileByID(int id);
        //Attorney editProfile(int id, Attorney ATSObj);
        string updateProfileByID(AttorneyPUT ats, int id);
    }
}
