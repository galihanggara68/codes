using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { set; get; }

        [Required]
        [StringLength(15)]
        public string FirstName { set; get; }

        [Required]
        [StringLength(15)]
        public string LastName { set; get; }
    }
}