using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Demo.Entity;
namespace Demo.Database
{
   public class EmployeeRepostory: Repository<Employee>,IEmployeeRepostory
    {
        public EmployeeRepostory(DemoContext demoContext) :base(demoContext)
        {

        }


    }
}
