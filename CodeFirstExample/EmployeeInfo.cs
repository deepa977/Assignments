﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CodeFirstExample
{
    //POCO Classes
    // plain Old CLR Objects
    class EmployeeInfo
    {
        [Key]//primary key in table
        public int EmpID { get; set; }
        [Required]//not null in table
        public string Name { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        [Range(minimum:10000,maximum:50000,ErrorMessage ="Salary Between 10000 and 50000")]
        public double  Salary { get; set; }
    }
}
