using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionarioGeralMuchMore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Questionário de conhecimentos Gerais";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em Contato";

            return View();
        }
    }
}