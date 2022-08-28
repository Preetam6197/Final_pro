using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class IntReql
    {
        [Key]
        public int LId { get; set; }
        [Required]

        public string LType { get; set; }
        [Required]
        public string LReason { get; set; }
    }
}
