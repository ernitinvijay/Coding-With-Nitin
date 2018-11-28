using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo
{
    public class EntityToViewmodelMapping:Profile
    {
        public EntityToViewmodelMapping() : base("EntityToViewmodelMappings")
        {

            CreateMap<Demo.Entity.Employee, Models.EmployeeViewModel>();

            CreateMap<Models.EmployeeViewModel,Demo.Entity.Employee>();
        }
    }
}