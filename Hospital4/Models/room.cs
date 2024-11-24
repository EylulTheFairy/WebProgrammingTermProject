using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Hospital4.Models
{
    public class room
    {
        [Key]
        public int roomID {  get; set; }
        public int roomCapacity { get; set; }
        public bool availability { get; set; }

    }
}