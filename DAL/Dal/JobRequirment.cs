using DAL.Database;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dal
{
    public class JobRequirment : IjobRequirement
    {
        private readonly DalContext _dalContext;
        public JobRequirment(DalContext dalContext)
        {
            _dalContext = dalContext;
        }
        public List<jobRequirements> jobRequirements(int id)
        {
            return _dalContext.jobrequirements.Where(x=>x.jobId.id == id).ToList();
        }
    }
}
