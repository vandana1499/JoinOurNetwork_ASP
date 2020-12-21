using System;
using System.Collections.Generic;
using System.Text;

namespace Modal
{
    public enum Specialization
    {

        Tax = 0,
        Civil=1,
        Criminal=2,
        Corporate=3,
        Labour=4,
        RealEstate=5,
        Intellectual=6

    }
    public class AttorneyPUT
    {
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressPUT Address { get; set; }

        public Specialization Specialization { get; set; }



    }
}
