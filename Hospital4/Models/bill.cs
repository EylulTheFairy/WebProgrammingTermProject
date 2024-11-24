using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Hospital4.Models
{
    public class bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int billID { get; set; }
        public float billAmount { get; set; }
        public int patientID { get; set; }
    }
}