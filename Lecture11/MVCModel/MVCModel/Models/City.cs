using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModel.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public virtual int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}