using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modal
{
    public class AddressEntities
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hno { get; set; }
     
        public string Lane1 { get; set; }

        public string Lane2 { get; set; }


        public string City { get; set; }

        [Required]
        public string State { get; set; }

    
        [StringLength(6, ErrorMessage = "The Zip code should be 6 digit")]
        public string Zip { get; set; }

        public AttorneyEntities attorneyEntities { get; set; }

       


    }
}
