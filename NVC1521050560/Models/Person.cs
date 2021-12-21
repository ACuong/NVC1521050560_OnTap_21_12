using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVC1521050560.Models
{
    public class Person
    {
        [Key]
        public string PersionID { get; set; }
        public string PersonName { get; set; }

    }
}