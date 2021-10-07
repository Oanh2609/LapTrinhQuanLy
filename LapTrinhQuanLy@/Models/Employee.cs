using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhQuanLy_.Models
{
   
        public class Employee : Person
        {
            public string Companny { get; set; }
            public string Address { get; set; }
        }
    
}
