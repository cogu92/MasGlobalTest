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
    public class ConsumeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            
            ConsumeController controller = new ConsumeController();
                         
            ViewResult result = controller.Index() as ViewResult;
             
            Assert.IsNotNull(result);
        }

      
    }
}
