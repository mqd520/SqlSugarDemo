using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using SqlSugarDemo.Entity;

namespace SqlSugarDemo.IService
{
    /// <summary>
    /// User Service Interface
    /// </summary>
    public interface IUserService
    {
        bool IsLogin();
    }
}
