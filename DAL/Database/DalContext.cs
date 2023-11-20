using DAL.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Database
{
    public class DalContext : DbContext 
    {
        static readonly string connectionString = "Server=mysql-server-container; Port=3306;User ID=root;Password=password123;Database=temp";
        public  string _Connectionstringv2;
        public DalContext()
        {
            _Connectionstringv2 = connectionString;
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
    }
}
