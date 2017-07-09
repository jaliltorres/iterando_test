using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_iterando.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Person_id { get; set; }
        [Required]
        [StringLength(150)]
        public string Person_name { get; set; }
        [Required]
        [StringLength(150)]
        public string Person_lastname { get; set; }
        [Required]
        [StringLength(15)]
        public string Person_number { get; set; }
        [StringLength(300)]
        public string Person_address { get; set; }
    }
}