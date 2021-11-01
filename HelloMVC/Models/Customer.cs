using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HelloMVC.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="Your String is too long!")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Your Phone is too long!")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

    }
}