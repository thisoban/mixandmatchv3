using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Job
    {
        public int id { get; set; }
        [Required]
        [MaxLength(255)]
        public string name { get; set; }
        [Required]
        [MaxLength(255)]
        public string description { get; set; }
        [Required]
        public DateTime start { get; set; }
        [Required]
        public DateTime end { get; set; }
        public virtual Company companyid { get; set; }
        public virtual hiring_manager Hiring_Managerid { get; set; }  
    }
}