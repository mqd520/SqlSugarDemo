using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugarDemo.Entity;
using SqlSugarDemo.IRepository;

namespace SqlSugarDemo.Repository
{
    public class CustomersRepository : Repository<Customers>, ICustomersRepository
    {

    }
}
