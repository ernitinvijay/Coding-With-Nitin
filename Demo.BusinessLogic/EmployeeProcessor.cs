using Demo.Database;
using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic
{
    public class EmployeeProcessor: IEmployeeProcessor
    {
        public readonly IEmployeeUOW employeeUOW;

        public EmployeeProcessor(IEmployeeUOW employeeUOW)
        {
            this.employeeUOW = employeeUOW;
        }
        public ICollection<Employee> GetAllEmployee()
        {
            return employeeUOW.GetAllEmployee().OrderBy(x=> x.Name).ToList();
        }
    }
}
