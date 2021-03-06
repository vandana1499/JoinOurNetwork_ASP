﻿using AttorneyService.DataAccessLayer;
using AttorneyService.Mapper;
using Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttorneyService.BusinessLayer
{
    public class AttorneyOperation:IAttorneyOperation
    {
        public static List<Attorney> AllAttorney = new List<Attorney>();
       
        public IAttorneyRepository repository;
        public AttorneyOperation(IAttorneyRepository attorneyRepository)
        {
            repository=attorneyRepository;
        }
        public Attorney createProfile(Attorney atr)
        {

            //var exists = obj1.Any(x => atr.Email == atr.Email);
          
                Attorney obj = new Attorney();

                obj.FirstName = atr.FirstName;
                if (atr.MiddleName != null) {
                    obj.MiddleName = atr.MiddleName;

                }
                obj.LastName = atr.LastName;
                obj.Email = atr.Email;

                obj.Address = atr.Address;
                obj.Specialization = atr.Specialization;

                //AllAttorney.Add(obj);


                AttorneyEntities AtrResult = repository.Add(obj.ConvertFromAtrToAtrEnt());
                return AtrResult.ConvertFromAtrEntToAtr();
          
        
           



        }
        public List<Attorney> getAllProfiles()
        {
            var obj= repository.GetAttorneys();
            List<Attorney> obj1 = new List<Attorney>();

            for(int i=0;i<obj.Count;i++) {
                var temp=obj[i].ConvertFromAtrEntToAtr();
                obj1.Add(temp);
            }
            return obj1;

        }
       public List<Attorney> getAllProfilesByCity(string city)
        {
            var obj = repository.GetAttorneys();
            List<Attorney> obj1 = new List<Attorney>();

            for(int i=0;i<obj.Count;i++) {
                if(obj[i].AddressEntities.City==city) {
                    var temp = obj[i].ConvertFromAtrEntToAtr();
                    obj1.Add(temp);
                }
            }
            return obj1;

        }
        public List<string> getAllProfilesByDistinctCity()
        {
            var obj = repository.GetAttorneys();

          
            List<string> distinct = new List<string>();
            for (var i = 0; i < obj.Count; i++) {
                if (!distinct.Contains(obj[i].AddressEntities.City)) {
                    distinct.Add(obj[i].AddressEntities.City);
                    
                }
            }

            return distinct;

        }
       public List<Attorney> DeleteProfileByID(int id)
        {
            var obj = repository.GetAttorneys();
          
           
            var obj1=obj.FirstOrDefault(x => x.id == id);
            obj1.isActive = false;
            repository.Delete(obj1);

            return getAllProfiles();


        }

      


        public Attorney updateProfileByID(AttorneyPUT ats, int id)
        {
            var obj1 = repository.GetAttorneys();
            var obj2 = obj1.First(a => a.id == id);
           if(obj2==null) {
                throw new CustomNotFoundException("Not found");
            }
           else {
                repository.update(ats, id);
                return obj1.First(a => a.id == id).ConvertFromAtrEntToAtr();
            }
        }
    }
}
