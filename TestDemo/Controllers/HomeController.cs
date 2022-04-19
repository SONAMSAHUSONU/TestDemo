using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDemo.Controllers
{
    public class HomeController : Controller
    {
        public string  Index(string id, string name)//this is query string we have to given query string : localhost:4971/Home/Index/10?name=Sonam
        {
            TempData["name"] = name; //here we storing data
            Session["ID"] = id;
            return "ID=" + id + "<br/>Name= " + name;
        }

        public ActionResult About()
        {
            object name = TempData["name"];//here we read the data
            object id = Session["ID"];//in real time application we will use session 
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            object name = TempData["name"];//it try to read here also it is show null value if we start again
            object id = Session["ID"];
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}