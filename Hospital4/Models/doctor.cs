using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital4.Models
{
    public class doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        [StringLength(100)]
        public string Specialty { get; set; }
        public string Department { get; set; }

        public float Rating { get; set; }
        public string Prof { get; set; }
        public string Contact { get; set; }
    }
}