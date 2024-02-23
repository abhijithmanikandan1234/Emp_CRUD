using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Emp_CRUD.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        
        [Required(ErrorMessage = "Enter the Name")]
        public string Name { get; set; }
        

  
        public int Age { get; set; }

        
        public int Salary { get; set; }

        [Required(ErrorMessage = "Enter the Designation")]
        public string Designation {  get; set; }

        [Required(ErrorMessage = "Enter the Place")]
        public string Place {  get; set; }
    }
}