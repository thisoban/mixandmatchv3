using DTO;
using Microsoft.EntityFrameworkCore;

namespace mixandmatchv3
{
    public class MMContext: DbContext
    {
        static readonly string connectionString = "Server=localhost; Port=3308;User ID=root;Password=password123;Database=temp";
        private readonly string? connectionString1;

        public MMContext(string? connectionString1)
        {
            this.connectionString1 = connectionString1;
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<hiring_manager> hiring_Managers { get; set; }  
        public DbSet<jobRequirements> jobrequirements { get; set; } 
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public Job GetJob(int jobId) => Jobs.Include(c => c.companyid).Include(a => a.Hiring_Managerid).FirstOrDefault(x => x.id == jobId);

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

        public List<jobRequirements> GetJobrequirementsFromJobId(int jobId)
        {
            return jobrequirements.Where(x => x.jobId.id == jobId).ToList();
        }
    }
}
