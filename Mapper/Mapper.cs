using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.Mapper
{
   public static class Mapper
    {
       public static AttorneyEntities ConvertFromAtrToAtrEnt(this Attorney atr)
        {
            
            return new AttorneyEntities() {
                FirstName = atr.FirstName,
                MiddleName = atr.MiddleName,
                LastName = atr.LastName,
                Email = atr.Email,
                Specialization = atr.Specialization,
                AddressEntities=atr.Address.ConvertFromAddrToAddrEnt()
            };
   
        }
        public static AddressEntities ConvertFromAddrToAddrEnt(this Address atr)
        {
            return new AddressEntities() {
               Lane1=atr.Lane1,
               Lane2=atr.Lane2,
               City=atr.City,
               Zip=atr.Zip,
               State=atr.State

            };

        }

        public static Attorney ConvertFromAtrEntToAtr(this AttorneyEntities atr)
        {
            return new Attorney() {
                id = atr.id,
                FirstName = atr.FirstName,
                MiddleName = atr.MiddleName,
                LastName = atr.LastName,
                Email = atr.Email,
                Specialization = atr.Specialization,
                Address = atr.AddressEntities == null ? null : atr.AddressEntities.ConvertFromAddrEntToAddr()

            };

        }
        public static Address ConvertFromAddrEntToAddr(this AddressEntities atr)
        {
            return new Address() {
                hno=atr.hno,
                Lane1 = atr.Lane1,
                Lane2 = atr.Lane2,
                City = atr.City,
                Zip = atr.Zip,
                State = atr.State

            };

        }

    }
}
