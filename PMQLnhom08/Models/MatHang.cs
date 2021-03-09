using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLnhom08.Models
{
    [Table("MatHangs")]
    public class MatHang
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Gia { get; set; }
    }
}