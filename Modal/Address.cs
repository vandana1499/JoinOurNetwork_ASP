using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modal
{
   public class Address
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hno { get; set; }

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
