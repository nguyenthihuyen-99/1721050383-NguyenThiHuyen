using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1721050383_NguyenThiHuyen.Models.MyProcess
{
    public class Xuly
    {
        int n, i;
        int dem = 0;
        string ketqua = "";
        ketqua = "nhap n bat ki: ";
            n = Convert.ToInt32(nhapn);
            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    dem++;
            if (dem == 0)
                ketqua = ("số đã cho là số nguyên tố");
            else
                ketqua = ("số đã cho không là số nguyên tố");
    }
}