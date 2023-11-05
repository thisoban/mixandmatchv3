using DTO;
using Microsoft.EntityFrameworkCore;

namespace mixandmatchv3
{
    public class MMContext: DbContext
    {
        static readonly string connectionString = "Server=localhost; Port=3308;User ID=root;Password=password123;Database=temp";
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<hiring_manager> hiring_Managers { get; set; }  
        public DbSet<jobrequirements> jobrequirements { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public Job GetJob(int jobId)
        {
            return Jobs.FirstOrDefault(x => x.id == jobId);
        }

        public List<Job> getJobs()
        {
            return Jobs.ToList();
        }

        public List<Company> getCompanys()
        {
            return companies.ToList();  
        }
        public List<hiring_manager> GetHiring_Managers()
        {
            return hiring_Managers.ToList();
        }

        public List<jobrequirements> GetJobrequirementsFromJobId(int jobId)
        {
            return jobrequirements.Where(x => x.jobId.id == jobId).ToList();
        }
    }
}
