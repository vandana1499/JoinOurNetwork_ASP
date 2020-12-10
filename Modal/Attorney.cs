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
        
        Tax,
       
    }
   public class Attorney
    {

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
        
       
        [Required]
        public Address Address{ get; set; }
        
        [Required]
        public specialization Specialization { get; set; }





    }
}
