using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entity_first.Models
{
  
    public class GioHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //[ForeignKey("EmpID")]
        public string IDKhachHang { get; set; }

       // [ForeignKey("IDSanPham")]
        public string IDSanPham{ get; set; }
    }
}