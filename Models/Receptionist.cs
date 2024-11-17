using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalTest3.Models
{
    public class Receptionist
    {
        [Key]
        public int ReceptionistID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }

}