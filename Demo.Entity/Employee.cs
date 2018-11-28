using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Demo.Entity
{
    public class Employee 
    {
      
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
