using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Modal
{
    public enum specialization
    {
        Tax = 0,
        Civil = 1,
        Criminal = 2,
        Corporate = 3,
        Labour = 4,
        RealEstate = 5,
        Intellectual = 6
    }
   public class Attorney
    {
        public Attorney()
        {
            isActive = true;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email{ get; set; }

        public Boolean isActive { get; set; }

        [Required]
        public Address Address{ get; set; }
        
        [Required]
        public specialization Specialization { get; set; }





    }
}
