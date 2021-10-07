using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhQuanLy_.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "ID Khong duoc de trong !")]
        public string PersonID { get; set; }
        [AllowHtml]
        public string PersonName { get; set; }
    }
}
