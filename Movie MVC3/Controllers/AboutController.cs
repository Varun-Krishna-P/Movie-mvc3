using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_MVC3.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

       public ActionResult Index()
        //public string Index()
        {
            ViewBag.Message = "About us page";
           // return "This is my <b>default</b> action..."; 
            //System.Diagnostics.Debug.WriteLine(Request.AcceptTypes.Contains("text/html"));
            return View();
        }
       public ActionResult Welcome(string name, int numTimes)
       {
           ViewBag.Title = "Welcome Page";
           ViewBag.Message = "We take immense pleasure in welcoming the user: " + name;
           ViewBag.NumTimes = numTimes;
           return View();
       }

    }
}
