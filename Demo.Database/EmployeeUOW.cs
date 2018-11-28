using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity;
namespace Demo.Database
{
    public class EmployeeUOW : IEmployeeUOW
    {
      //  public readonly IEmployeeRepostory employeeRepostory;

        //public EmployeeUOW(IEmployeeRepostory employeeRepostory)
        //{
        //    this.employeeRepostory = employeeRepostory;
        //}

        public ICollection<Employee> GetAllEmployee()
        {
            //return employeeRepostory.GetAll().ToList();

            return new List<Employee>
            {
                new Employee{ Id=1,Name="Nitin",Address="Test"  },
                new Employee{ Id=2,Name="B",Address="Test1"  },
            };
        }
    }
}
