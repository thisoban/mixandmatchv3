using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IJobDAL
    {
        Job GetJob(int jobId);
        List<Job> getJobs();
    }
}
