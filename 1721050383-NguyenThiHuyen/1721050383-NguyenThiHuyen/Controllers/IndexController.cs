using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1721050383_NguyenThiHuyen.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index(string Hoten, string ngaysinh)


        {
            ViewBag.thongbao = "chào mừng: " + Hoten;
            ViewBag.ngaysinh = ngaysinh;
            return View();
        }
    }
}