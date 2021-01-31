using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1721050383_NguyenThiHuyen.Controllers
{
    public class tinhtongController : Controller
    {
        // GET: tinhtong
            public ActionResult tinhtong(string nhapn)
            {
                int n;
                double s = 0;
                string ketqua = "";
                ketqua = "Tinh tong day so :";
                n = Convert.ToInt32(nhapn);
                for (double i = 1; i <= n; i++)
                {
                    s += 1 / i;
                }
                ViewBag.message = " tong cua day phan tu:" + s;
                return View();
            }
        }
    }