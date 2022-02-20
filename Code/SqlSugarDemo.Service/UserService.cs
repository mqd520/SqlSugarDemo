using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugarDemo.IService;

namespace SqlSugarDemo.Service
{
    /// <summary>
    /// User Service
    /// </summary>
    public class UserService : IUserService
    {
        public bool IsLogin()
        {
            return true;
        }
    }
}
