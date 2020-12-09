using System;
using System.Collections.Generic;
using System.Text;

namespace Modal
{
    public enum Specialization
    {

        Tax = 0,

    }
    class AttorneyPUT
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressPUT Address { get; set; }
        public Specialization Specialization { get; set; }



    }
}
