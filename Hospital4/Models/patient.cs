using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital4.Models
{
    public class patient
    {
        [Key]
        public int PatientID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }            // Patient's name
        [StringLength(1)]
        public string Gender { get; set; }          // Patient's gender (M/F)
        [StringLength(20)]
        public string ContactNo { get; set; }       // Patient's contact number
        public DateTime BirthDate { get; set; }     // Patient's birth date
        [StringLength(100)]
        public string Address { get; set; }         // Patient's address
        [StringLength(50)]
        public string State { get; set; }           // Patient's state
        [StringLength(50)]
        public string City { get; set; }            // Patient's city
        [StringLength(20)]
        public string BuildNo { get; set; }         // Patient's building number
        [StringLength(20)]
        public string ISA { get; set; }             // Insurance status
        public DateTime DateAdmitted { get; set; }  // Date of admission
        public DateTime? DateDischarged { get; set; }  // Date of discharge (nullable)
        public string Pdetails { get; set; }
    }
}