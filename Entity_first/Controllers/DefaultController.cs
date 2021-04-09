using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity_first.Models;


namespace Entity_first.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        db data = new db();
        public ActionResult Index(string ID)
        {

            IList<KhachHang> TV = new List<KhachHang>()
              { new KhachHang { EmpID=1 ,Name="HI@GMAIL.COM", Address="123", ko="1"},
           new KhachHang { EmpID=2 ,Name="heloo@GMAIL.COM", Address="456", ko="2"}
                };
            ViewBag.KH = TV;

            IList<GioHang> GH = new List<GioHang>()
              { new GioHang { ID=1 ,IDSanPham="2",IDKhachHang="1"},
           new GioHang {  ID=2 ,IDSanPham="3",IDKhachHang="2"}
                };
            ViewBag.giohang = GH;
            return View();
        }


        public ActionResult login()
        {
            IList<GioHang> TVy = new List<GioHang>()
              { new GioHang { ID=1 ,IDSanPham="2",IDKhachHang="1"},
           new GioHang {  ID=2 ,IDSanPham="3",IDKhachHang="2"}
                };
            ViewBag.list = TVy;

            return  PartialView("login",TVy);
        }
    }
}