using DAL.Dal;
using DAL.Interfaces;
using DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDAL _IuserDal;
        public UserLogic(IUserDAL userDAL)
        {
            _IuserDal = userDAL;
        }

        public User userGet(string email, string password)
        {
           User user = new User();

           if (email == null)
           {
                throw new ArgumentNullException("email");
           }
           if (password == null)
           {
                throw new ArgumentNullException("password");
           }
           if(EmailValid(email)) 
           {
              user =  _IuserDal.GetUser(email, password);  
           }

           return user;
        }

        private bool EmailValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
