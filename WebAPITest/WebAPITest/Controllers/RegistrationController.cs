using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Index(Registration NewUser)
        {
            try
            {
                if (NewUser.Repassword != null)
                {
                    var data = NewUser;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}