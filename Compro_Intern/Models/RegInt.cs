using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class RegInt
    {
        [Key]
        public int RegIntId { get; set; }

        [Required]
        public string IntName { get; set; }
        [Required]
        public string IntEmail { get; set; }
        [Required]
        public string IntPas { get; set; }
        [Required]
        public string IntNu { get; set; }
        [Required]
        public string IntAge { get; set; }
        [Required]

        public string IntCity { get; set; }
        [Required]
        public string IntAddr { get; set; }
        


    }
}
