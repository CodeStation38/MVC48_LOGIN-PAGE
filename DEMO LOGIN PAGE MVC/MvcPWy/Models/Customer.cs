using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace MvcPWy.Models
{
    public class Customer
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public string PrefferedColor { get; set; }
        public string MainHobby { get; set; }
        public string SSN { get; set; }
        public int NumberOfRooms { get; set; }


    }
}