using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDalContext :IDisposable
    {       
         DbSet<Job> Jobs { get; set; }
         DbSet<Company> companies { get; set; }
         DbSet<hiring_manager> hiring_Managers { get; set; }
         DbSet<jobRequirements> jobrequirements { get; set; }
         DbSet<User> users { get; set; }
    }
}
