using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasGlobal;
using MasGlobal.Controllers;

namespace MasGlobal.Tests.Controllers
{
    [TestClass]
    public class ApiControllerTest
    {
        [TestMethod]
        public void GetEmployee()
        {

            GetEmployeesController Apicontroller = new GetEmployeesController();
                         
            var result = Apicontroller.Get(1) ;
            Assert.IsTrue(result.Count>0);
        }

        [TestMethod]
        public void GetAllEmployee()
        {

            GetEmployeesController Apicontroller = new GetEmployeesController();

            var result = Apicontroller.Get();
            Assert.IsTrue(result.Count > 1);
        }

        [TestMethod]
        public void NotFindEmployee()
        {

            GetEmployeesController Apicontroller = new GetEmployeesController();

            var result = Apicontroller.Get(1233343);
            Assert.IsTrue(result.Count ==0);
        }
    }
}
