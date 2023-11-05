using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class jobrequirements
    {
        public int id { get; set; }
        [Required]
        [MaxLength(60)]
        public string name { get; set; }
        [MaxLength(255)]
        [Required]
        public string description { get; set; }
        public virtual Job jobId { get; set; }
    }
}
