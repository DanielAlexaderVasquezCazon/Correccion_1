using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RstCountry.Models
{
 

    public class Language
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        [Key]
        public string name { get; set; }
        public string nativeName { get; set; }
    }
    public class Country
    {   
        [Key]
        [Required]
        [StringLength(3,MinimumLength = 3)]
        public string alpha3Code { get; set; }

        [Required]
        [StringLength(50,MinimumLength =3)]
        public string name { get; set; }

        [Required]

        public List<string> callingCodes { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string region { get; set; }

        [Required]
        public double area { get; set; }

        [Required]
        public List<Language> languages { get; set; }

        [Required]
        [RegularExpression("^https://[A-Za-z0-9./]+$")]
        public string flag { get; set; }
        
    }
}