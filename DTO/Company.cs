using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Company
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string adres { get; set; }
        [Required]
        [MaxLength(255)]
        public string city { get; set; }
        [Required]
        [MaxLength(10)]
        public string zipcode { get; set; }
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MaxLength(15)]
        public string phone { get; set; }
        [Required]
        [MaxLength(255)]
        [Url]
        public string website { get; set; }
    }
}
