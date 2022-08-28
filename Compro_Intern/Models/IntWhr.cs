using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class IntWhr
    {
        [Key]
        public int HId { get; set; }
        [Required]

        public string CHr { get; set; }
        [Required]
        public string IHr { get; set; }


    }
}
