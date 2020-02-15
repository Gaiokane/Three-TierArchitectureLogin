using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class UserManager
    {
        //新建数据访问层对象
        UserService service = new UserService();

        public bool Login(User user)
        {
            return service.Login(user);
        }
    }
}