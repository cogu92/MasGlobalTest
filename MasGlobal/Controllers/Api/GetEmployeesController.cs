using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MasGlobal;
using System.Web.Mvc;
using System.Web;
using MasGlobal.Models;
namespace MasGlobal.Controllers
{
    public class GetEmployeesController : ApiController
    {
        public IList<DtoEmployee> Get(int id = 0)
        {
            DataAccess dta = new DataAccess();
            IList<DtoEmployee> Data = dta.get("http://masglobaltestapi.azurewebsites.net/api/Employees");

            if (id != 0)
                Data = Data.Where(x => x.id == id).ToList();

            return  Data;
        }

      
    }

}
