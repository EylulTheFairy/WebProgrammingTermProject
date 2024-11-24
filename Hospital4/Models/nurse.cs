using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital4.Models
{
    public class nurse
    {
        [Key]
        public int EmployeeID { get; set; } // Primary Key
        public string Name { get; set; }    // Name of the employee
        public string Position { get; set; } // Position (e.g., Doctor, Nurse, Receptionist)
        public string Department { get; set; } // Department the employee belongs to
        public string Contact { get; set; }
    }
}