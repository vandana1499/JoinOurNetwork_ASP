using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modal
{
  public class AttorneyEntities
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
     
        public string LastName { get; set; }
       
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("AddressEntities")]
        public int hno { get; set; }
        public AddressEntities AddressEntities { get; set; }

        
   
        public specialization Specialization { get; set; }


    }
}
