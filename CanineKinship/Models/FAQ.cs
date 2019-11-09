using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanineKinship.Models
{
    public class FAQ
    {
        [Key]
        public int QuestionID { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }

    }
}