using DTO;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace mixandmatchv3.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class JobsController : Controller
        {
            private readonly IJobLogic _jobLogic;

            private readonly MMContext _context;
            public JobsController( IJobLogic jobLogic)
            {
                _jobLogic = jobLogic;
            }

            // GET: JobsController/Details/5
            [HttpGet("details", Name = "getjob")]
            public IActionResult Details(int id)
            {
                Job job1v= _jobLogic.getjob(id);
               
                Console.WriteLine(job1v);
                if (job1v == null)
                {
                    return NotFound("the job not found");
                }
                return Ok(job1v);
            }
            [HttpGet("list", Name = "getjoblist")] // Add a new route for listing all jobs
            public IActionResult ListJobs()
            {
                List<Job> jobs = _jobLogic.getjobs(); // Replace with your method to fetch all jobs
                return Ok(jobs);
            }
        }
    }
