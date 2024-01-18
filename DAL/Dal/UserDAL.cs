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
    public class UserDAL : IUserDAL
    {
        private readonly DalContext _dalContext;
        public UserDAL(DalContext dalContext)
        {
            _dalContext = dalContext;
        }

        public User GetUser(string email, string password)
        {
           return  _dalContext.users.Where(x => x.Email == email).Where(y => y.Password == password).FirstOrDefault();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }

    


}
