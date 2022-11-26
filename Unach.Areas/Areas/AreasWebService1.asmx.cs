using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Areas
{
    /// <summary>
    
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class AreasWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a amigos";
        }
        [WebMethod]
        public decimal Paralelogramo(decimal l1, decimal l2)
        {
            Calcular c = new Calcular();
            return c.Cuadrado(l1, l2);
        }
        [WebMethod]
        public decimal Trapezoide(decimal a, decimal b, decimal c, decimal d)
        {
            Calcular c = new Calcular();
            return c.Triangulo(a, b, c, d);
        }
    }
}
