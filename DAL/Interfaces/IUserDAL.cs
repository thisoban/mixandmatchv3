using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        User GetUser(string email , string password);
        User UpdateUser(User user);

    }
}
