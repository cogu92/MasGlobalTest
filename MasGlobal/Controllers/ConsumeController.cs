using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MasGlobal.Models;
namespace MasGlobal.Controllers
{
    public class ConsumeController : Controller
    {
         
        public ActionResult Index()
        {
            IEnumerable<DtoEmployee> getapicontroler =  new GetEmployeesController().Get();
          
            return View( getapicontroler);
        }

       

        [HttpPost]
        public ActionResult Report(string reportName)
        {
            

            IEnumerable<DtoEmployee> getapicontroler = new GetEmployeesController().Get(Convert.ToInt32( reportName.Equals("")?"0": reportName));


            return View("Index", getapicontroler);
        }
    }
}