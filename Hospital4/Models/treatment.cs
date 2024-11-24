using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital4.Models
{
    public class treatment
    {
        [Key]
        public int TreatmentID { get; set; } // Primary Key
        public int patientID { get; set; } 
        public string treatmentName { get; set; }
        public string doctorID { get; set; }
        public string nurseID { get; set; }
    }
}
