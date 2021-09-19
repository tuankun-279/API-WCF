using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStudent.Controllers
{
    public class GetStudentController : Controller
    {
        public static ServiceReferenceGetStudent.Service1Client myService = new ServiceReferenceGetStudent.Service1Client();
        // GET: GetStudent
        public ActionResult Index()
        {            
            ViewBag.ListSinhVien = myService.Get_ListSinhVien();
            return View();
        }
        public ActionResult Create(string Name, string Email)
        {            
            ServiceReferenceGetStudent.SinhVien sinhvien = new ServiceReferenceGetStudent.SinhVien();
            if(!String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(Email))
            {
                sinhvien.Name = Name;
                sinhvien.Email = Email;
                myService.Insert_ListSinhVien(sinhvien);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}