using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AspNetMvcXuanThuLab.Controllers
{
    public class FirstController : Controller
    {
        public string test()
        {
            return "Day la First index";
        }
        //GET: First
        public ActionResult Index()
        {
            
            return View();
        }
        
    }
}