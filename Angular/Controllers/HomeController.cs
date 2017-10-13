using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular.Models;
namespace Angular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DataBase_Access_Layer.db dblayer = new DataBase_Access_Layer.db();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(Registeration rs)
        {
        

            string result = string.Empty;
            try
            {
                dblayer.Add_record(rs);
                result = "Done..!!!..";
            }
            catch(Exception)
            {
                result = "Failed...";
               //throw;

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
   
    }
}