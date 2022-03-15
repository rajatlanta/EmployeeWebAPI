using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models
{
    public partial class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string Salary { get; set; }
        public int? ManagerId { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Department Department { get; set; }
    }
}
