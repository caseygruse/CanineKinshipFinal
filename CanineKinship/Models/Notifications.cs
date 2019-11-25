using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanineKinship.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationID { get; set; }

        public string Title { get; set; }

        [Required]
        public string NotificationText { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

    }
}