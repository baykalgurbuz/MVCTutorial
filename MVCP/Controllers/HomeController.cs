using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCP.Controllers
{
    public class HomeController : Controller
    {
        //Layout kısmı sabit kalan kısıma denir.Eski ismi Masterpage.
        //Değişen kısımlar ise Content'dir.
        public ActionResult Index()//Metod varsa View tarfında karşılığı olmalıdır.
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}