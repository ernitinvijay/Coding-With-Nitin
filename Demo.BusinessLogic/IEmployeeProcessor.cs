using Demo.Entity;
using System.Collections.Generic;


namespace Demo.BusinessLogic
{
    public interface IEmployeeProcessor
    {
        ICollection<Employee> GetAllEmployee();
    }
}
