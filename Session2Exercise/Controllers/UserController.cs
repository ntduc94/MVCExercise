﻿using Session2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session2.Controllers
{
    public class UserController : Controller
    {
        private List<User> Users = new List<User>
        {
            new User { Username = "user 1", Email = "email 1", Phone = "phone 1", Age = 1 },
            new User { Username = "user 2", Email = "email 2", Phone = "phone 2", Age = 2 },
            new User { Username = "user 3", Email = "email 3", Phone = "phone 3", Age = 3 }
        };

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            // list the user created data in top
            // response as response
            return Json(Users, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(string username, string email, string phone, int age)// receive data
        {
            var user = new User { Username = username, Email = email, Phone = phone, Age = age };
            Users.Add(user);
            return Json(user);// response json
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}