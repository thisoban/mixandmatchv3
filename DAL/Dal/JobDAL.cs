using DAL.Database;
using DAL.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dal
{
    public class JobDAL : IJobDAL
    {
        private readonly DalContext _dalContext;
        public JobDAL(DalContext dalContext) 
        {
            _dalContext = dalContext;
        }

        public Job GetJob(int jobId)
        {
            return _dalContext.Jobs.Include(c => c.companyid).Include(a => a.Hiring_Managerid).FirstOrDefault(x => x.id == jobId);
        }

        public List<Job> getJobs()
        {
            return _dalContext.Jobs.ToList();
        }

        private List<jobRequirements> jobRequirements(int jobid)
        {
            return _dalContext.jobrequirements.Where(x=>x.jobId.id == jobid).ToList();
        }
    }
}
