using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class IntRec
    {
        [Key]
        public int RecId { get; set; }
        [Required]
        public string RecName { get; set; }
        [Required]
        public string RecEmail { get; set; }
        [Required]
        public string RecPhn { get; set; }
        [Required]
        public string RecAdd{ get; set; }
        [Required]

        public string RecStatus { get; set; }

    }
}
