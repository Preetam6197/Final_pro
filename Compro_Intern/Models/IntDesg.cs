using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Models
{
    public class IntDesg
    {
        [Key]
        public int DesgId { get; set; }

        [Required]
        public string DesgName { get; set; }
        [Required]
        public string DesgRole { get; set; }
        [Required]
        public string DepName { get; set; }


    }
}
