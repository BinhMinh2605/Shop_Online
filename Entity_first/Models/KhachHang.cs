using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entity_first.Models
{
   
    public class KhachHang
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        public string Name { get; set; }

        public String Address { get; set; }

        public string ko { get; set; }

        // public virtual IEnumerable<KhachHang> GioHang { set; get; }


    }
}
