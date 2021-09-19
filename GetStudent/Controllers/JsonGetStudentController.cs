using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace GetStudent.Controllers
{
    public class JsonGetStudentController : ApiController
    {
        public static ServiceReferenceGetStudent.Service1Client myService = new ServiceReferenceGetStudent.Service1Client();
        public JToken GetStudent()
        {
            return JToken.FromObject(myService.Get_ListSinhVien());
        }
        public void AddStudent(ServiceReferenceGetStudent.SinhVien sinhVien)
        {
            myService.Insert_ListSinhVien(sinhVien);           
        }
    }
}
