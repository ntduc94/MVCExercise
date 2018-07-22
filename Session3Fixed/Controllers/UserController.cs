using Session3Fixed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Session3Fixed.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var path = HostingEnvironment.MapPath(@"/App_Data/data.txt");
            ViewBag.List = new List<User>();
            if (System.IO.File.Exists(path))
            {
                var lines = System.IO.File.ReadAllLines(path);
                foreach (var item in lines)
                {
                    ViewBag.List.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<User>(item));
                }
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string username, string email, string phone, int age)// receive data
        {
            var user = new User { Username = username, Email = email, Phone = phone, Age = age };
            var path = HostingEnvironment.MapPath(@"/App_Data/data.txt");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(user));
            }
            return View();
        }
    }
}