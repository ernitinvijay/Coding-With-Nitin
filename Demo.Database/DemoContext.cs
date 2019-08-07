using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Demo.Entity;
namespace Demo.Database
{
    public class DemoContext : DbContext
    {
        //static DemoContext()
        //{
        //    Database.SetInitializer<DemoContext>(null);
        //}
        public DemoContext() : base("Name=DemoContext")
        { }

        DbSet<Employee> Employees { get;set;}

    }
}
