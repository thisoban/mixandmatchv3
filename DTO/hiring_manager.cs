using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hiring_manager
    {
        public int id { get; set; }
        [Required]
        [MaxLength(60)]
        public string name { get; set; }
        [Required]
        [MaxLength(10)]
        public string phonenumber { get; set; }
        [Required]
        [MaxLength(255)]
        public string email { get; set; }
        [Required]
        [MaxLength(255)]
        public virtual Company companyid { get; set; }
    }
}
