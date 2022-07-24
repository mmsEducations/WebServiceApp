using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceApp
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. [System.Web.Script.Services.ScriptService]
    public class WebServiceAppCalculator : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Add(decimal s1, decimal s2)
        {
            return s1 + s2;
        }

        [WebMethod]
        public decimal Subtract(decimal s1, decimal s2)
        {
            return s1 - s2;
        }


        [WebMethod]
        public decimal Multiply(decimal s1, decimal s2)
        {
            return s1 * s2;
        }

        [WebMethod]
        public decimal Divide(decimal s1, decimal s2)
        {
            return s1 / s2;
        }

        [WebMethod]
        public int Exponentiation(int s1, int s2)
        {
            if (s2==0)
              return 1;

            int result = 1;
            for (int i = 1; i <=s2; i++)
            {
                result = result * s1;
            }
            return result;
        }

        [WebMethod]
        public decimal FindMaxAndEqual(decimal s1, decimal s2)
        {
            return s1 > s2 ? s1 : s2; 
        }

        [WebMethod]
        public double FindMinAndEqual(double s1, double s2)
        {
            return s1 < s2 ? s1 : s2;
        }
    }
}


/*
 
Web Servisler de yaptığımız Şey metodlar  tanımlayıp dışarıya erişim izni vermek 
Dışarıya açtığımız Metodların üzerinde [WebMethod] attributu eklenir 

 */