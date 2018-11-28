using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
namespace MVCDemo.Mapping
{
    public static class AutomapperConfi
    {
        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public static IMapper AutoConfiguration()
        {
            var confi = new MapperConfiguration(x =>
             {
                 x.AddProfile<EntityToViewmodelMapping>();
             }
            );
           return confi.CreateMapper();
        }
    }
}