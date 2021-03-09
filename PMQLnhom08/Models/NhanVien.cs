using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLnhom08.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string NameNv { get; set; }
        public int  IDNv { get; set; }
        public string AddressNv { get; set; }
    }
}