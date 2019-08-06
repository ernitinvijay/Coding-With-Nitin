using Demo.Database;
using Demo.Entity;
using System.Collections.Generic;
using System.Linq;

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
