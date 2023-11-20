using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int Id { get; set; } 
        public required string Email { get; set; }
        public string Name { get; set; }
        public required string Password { get; set; }
        public Role Role { get; set; }
        
    }
    public enum Role
    {
        User, 
        Admin,
        Hiring_Manager
    }
}
