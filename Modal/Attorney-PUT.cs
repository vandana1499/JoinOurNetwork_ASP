using System;
using System.Collections.Generic;
using System.Text;

namespace Modal
{
    public enum Specialization
    {

        Tax = 0,

    }
    public class AttorneyPUT
    {
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
     
        public AddressPUT Address { get; set; }
        public Specialization Specialization { get; set; }



    }
}
