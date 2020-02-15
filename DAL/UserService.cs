using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class UserService
    {
        public bool Login(User user)
        {
            if (user.UserName == "q" && user.UserPwd == "w")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}