using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entity_first.Models
{

    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        public string Name { get; set; }

        public string Gia { get; set; }

        //public virtual IEnumerable<SanPham> GioHang { set; get; }
    }

}