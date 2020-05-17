using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusContactWebAPI.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(128)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string address { get; set; }
    }
}
