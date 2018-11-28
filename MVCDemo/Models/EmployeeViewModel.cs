using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCDemo.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Employee name")]
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }
    }
}