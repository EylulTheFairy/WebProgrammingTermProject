using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalTest3.Models
{
    public class Nurse
    {
        [Key]
        public int EmployeeID { get; set; }          // Primary Key, Foreign Key to Employee

        public virtual Employee Employee { get; set; }
    }
}