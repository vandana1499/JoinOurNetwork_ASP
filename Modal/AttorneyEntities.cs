using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modal
{
  public class AttorneyEntities
    {
        public AttorneyEntities()
        {
            isActive = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
     
        public string LastName { get; set; }
       
        [EmailAddress]
        public string Email { get; set; }

        public Boolean isActive { get; set; }

        [ForeignKey("AddressEntities")]
        public int hno { get; set; }
        public AddressEntities AddressEntities { get; set; }

        
   
        public specialization Specialization { get; set; }


    }
}
