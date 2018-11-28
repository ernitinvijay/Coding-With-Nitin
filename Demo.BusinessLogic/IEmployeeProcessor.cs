﻿using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic
{
    public interface IEmployeeProcessor
    {
        ICollection<Employee> GetAllEmployee();
    }
}
