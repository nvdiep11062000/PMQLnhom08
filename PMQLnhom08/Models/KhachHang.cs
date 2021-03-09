using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLnhom08.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string NameKH { get; set; }
        public string AddressKH { get; set; }
        public int SDT { get; set; }
    }
}