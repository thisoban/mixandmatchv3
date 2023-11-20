using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class jobRequirements
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public required string Description { get; set; }
        public virtual required Job jobId { get; set; }
    }
}
