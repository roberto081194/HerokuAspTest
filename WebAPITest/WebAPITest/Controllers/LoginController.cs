using System;
using WebAPITest.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login body)
        {
            try
            {

                return View();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
    }
}