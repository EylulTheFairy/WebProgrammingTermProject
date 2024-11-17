using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HospitalTest3.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        [StringLength(100)]
        public string Specialty { get; set; }

        public float Rating { get; set; }
        public string Prof { get; set; }

        // Navigation property to Employee (assuming Employee is another model)
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
    }
}