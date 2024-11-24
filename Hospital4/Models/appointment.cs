using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital4.Models
{
    public class appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int appointmentID { get; set; }
        public DateTime appointmentDate { get; set; }
        public string appointmentDetails { get; set; }
        public int patientID { get; set; }
    }
}