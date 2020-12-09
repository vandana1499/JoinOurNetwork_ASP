using AttorneyService.DataAccessLayer;
using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.BusinessLayer
{
    public class AttorneyOperation:IAttorneyOperation
    {
        public static List<Attorney> AllAttorney = new List<Attorney>();
        public static int counter=0;
        public IAttorneyRepository repository;
        public AttorneyOperation(IAttorneyRepository attorneyRepository)
        {
            repository=attorneyRepository;
        }
        public string createProfile(Attorney atr)
        {
            Attorney obj = new Attorney();
            obj.FirstName = atr.FirstName;
            if(atr.LastName!=null)
            {
                obj.LastName = atr.LastName;

            }
            obj.LastName = atr.LastName;
            obj.Email = atr.Email;
            obj.Address = atr.Address;
            obj.Specialization = atr.Specialization;
            obj.id = ++counter;
            AllAttorney.Add(obj);
            repository.Add(obj);
            return "Successfully addedd";
            
        }
        public List<Attorney> getAllProfiles()
        {
            return AllAttorney;
        }

        //public Attorney editProfile(int id, Attorney ATSObj)
        //{
        //    Attorney obj = AllAttorney.Find(x => x.id == id);
        //}

    }
}
