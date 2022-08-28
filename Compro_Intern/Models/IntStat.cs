using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class IntStat
    {
        [Key]
        public int SId { get; set; }
        [Required]

        public int IntId { get; set; }
    }
}
