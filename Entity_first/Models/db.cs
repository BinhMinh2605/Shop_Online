using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Entity_first.Models
{
    public class db:DbContext
    {
        public db():base("name=demo")
        {

        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
    }
}
