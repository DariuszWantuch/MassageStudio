using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopProject.Models
{
    public class TimeService
    {
        [Key]
        public int Id { get; set; }
    
        [Required]
        [Display(Name = "Time Count")]
        public string Time { get; set; }
    }
}
