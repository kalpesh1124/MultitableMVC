using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultitableMVC.Models;

namespace MultitableMVC.Controllers
{
    public class studController : Controller
    {
        CompanyDataEntities2 db = new CompanyDataEntities2();
        public ActionResult create()
        {
            return View();
        }
        
        public ActionResult show()
        {
            List<student> cn = db.students.ToList();
            return View(cn);
        }

        public ActionResult Adddata()
        {
            return View();
        }
        [HttpPost]
        public string Adddata(student s1) 
        {
            db.students.Add(s1);
            db.SaveChanges();
            return "Student Added Successfully !!!";
        }
    }
}