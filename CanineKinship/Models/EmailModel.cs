﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanineKinship.Models
{
    public class EmailModel
    {
        [Required]
        [EmailAddress]
        public string SendersEmail{ get; set; }
        [Required]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}