using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Demo.Entity;
namespace Demo.Database
{
    public interface IEmployeeRepostory:IRepository<Employee>
    {

    }
}
