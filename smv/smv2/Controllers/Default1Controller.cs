using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using smv2.Models;

namespace smv2.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {

            CabeceraConnection c = new CabeceraConnection();
             c.GetAllCabecera();
            //ViewBag.a = a.Columns["C_DESCRI"].ToString();
           

            return View();
        }

    }
}
