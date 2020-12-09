using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modal
{
   public class Address
    {
        [Required]
        public string Lane1 { get; set; }
        
        public string Lane2 { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string State { get; set; }
        
        [Required]
        [StringLength(6,ErrorMessage ="The Zip code should be 6 digit")]
        public string Zip { get; set; }

        


    }

}
