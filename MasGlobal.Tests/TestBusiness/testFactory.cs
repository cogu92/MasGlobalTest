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
    public class testFactory
    {
        [TestMethod]
        public void MonthtlySalary()
        {
            Employees GetAnualSalary = Creator.CreatorSalary("MonthlySalaryEmployee");
            double anualSalary = GetAnualSalary.AnualSalary(100, 150);
            Assert.IsTrue(anualSalary.Equals(1800));
        }

        [TestMethod]
        public void HourlySalary()
        {

            Employees GetAnualSalary = Creator.CreatorSalary("HourlySalaryEmployee");
            double anualSalary = GetAnualSalary.AnualSalary(100, 150);
            Assert.IsTrue(anualSalary.Equals(144000));
        }


    }
}
