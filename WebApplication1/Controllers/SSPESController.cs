using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSPES;

namespace WebApplication1.Controllers
{
    public class SSPESController : Controller
    {      
        public string erkenneEingabe()
        {
            string eingabe = Request.Form["eingabe"];

            return eingabe;
        }
    }
}
