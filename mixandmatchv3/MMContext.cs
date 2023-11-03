using DTO;
using Microsoft.EntityFrameworkCore;

namespace mixandmatchv3
{
    public class MMContext: DbContext
    {
        static readonly string connectionString = "Server=localhost; Port=3308;User ID=root;Password=password123;Database=temp";
        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public Job GetJob(int jobId)
        {
            return Jobs.FirstOrDefault(x => x.id == jobId);
        }

        internal List<Job> getJobs()
        {
            return Jobs.ToList();
        }
    }
}
