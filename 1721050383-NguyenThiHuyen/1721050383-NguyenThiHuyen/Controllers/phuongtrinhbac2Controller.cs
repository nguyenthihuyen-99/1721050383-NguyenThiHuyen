using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1721050383_NguyenThiHuyen.Controllers
{
    public class phuongtrinhbac2Controller : Controller
    {
		// GET: phuongtrinhbac2
		public ActionResult phuongtrinhbac2(string hesoA, string hesoB, string hesoC)
		{
			Double a, b, c, delta, x1 = 0, x2 = 0;
			string Ketqua = "";
			a = Convert.ToDouble(hesoA);
			b = Convert.ToDouble(hesoB);
			c = Convert.ToDouble(hesoC);
			delta = b * b - 4 * a * c;
			if (delta > 0)
			{
				//Có hai nghiệm phân biệt
				x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				x2 = (-b - Math.Sqrt(delta)) / (2 * a);
				Ketqua = ("Phương trình có hai nghiệm phân biệt:");
				Ketqua = ("x1 = " + x1 + ", x2 = " + x2);
			}
			else if (delta == 0)
			{
				//Có nghiệm kép
				x1 = x2 = -b / (2 * a);
				Ketqua = ("Phương trình có nghiệm kép:");
				Ketqua = ("x1 = x2 = " + x2);
			}
			else
				Ketqua = ("Phương trình vô nghiệm");
			ViewBag.thongbao = "ket qua của pt: " + Ketqua;
			return View();
		}
	}
}