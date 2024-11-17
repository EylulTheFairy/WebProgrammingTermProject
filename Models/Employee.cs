using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalTest3.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; } // Primary Key
        public string Name { get; set; }    // Name of the employee
        public string Position { get; set; } // Position (e.g., Doctor, Nurse, Receptionist)
        public string Department { get; set; } // Department the employee belongs to
        public decimal Salary { get; set; } // Salary of the employee
        public string Contact { get; set; } // Contact number or email

        // Navigation property to link Employee to Doctor, Nurse, Receptionist, etc.
        public virtual ICollection<Doctor> Doctors { get; set; } // Doctor specific details
    }
}