using DAL.Interfaces;
using DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class JobLogic : IJobLogic
    {
        private readonly IJobDAL _Ijobdal;
        private readonly IjobRequirement _ijobRequirement1;
        public JobLogic(IJobDAL dAL, IjobRequirement ijobRequirement)
        {
            _Ijobdal = dAL;
            _ijobRequirement1 = ijobRequirement;
        }
        public JobLogic( IJobDAL jobDAL)
        {
            _Ijobdal= jobDAL;
        }

        public Job getjob(int id)
        {
          Job job =   _Ijobdal.GetJob(id);
            if (job.id != id)
            {
                throw new Exception("not found correct job");
            }
            if (job.Hiring_Managerid.name == null) {
                throw new NullReferenceException("not found hiring manager"); 
            }
            List<jobRequirements> jobRequirements = _ijobRequirement1.jobRequirements(id);

            jobDetails jobDetails = new jobDetails()
            {

            };
            return job;
        }

        public List<Job> getjobs()
        {
            List<Job> jobs = _Ijobdal.getJobs();
            if (jobs == null)
            {
                throw new Exception("not found jobs");
            }
            return jobs;
        }
    }
}
