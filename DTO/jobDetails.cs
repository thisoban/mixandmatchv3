using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class jobDetails
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

       public  List<jobRequirements> jobRequirements { get; set; }

        public jobDetails() { }
        
        public jobDetails(jobRequirements jobrequirement, Job job)
        {
            id = job.id;
            name = job.name;
            description = job.description;
            start = job.start;
            end = job.end;
            companyid = job.companyid;
            Hiring_Managerid = job.Hiring_Managerid;
        }
    }


}
