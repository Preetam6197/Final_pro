using Compro_Intern.Controllers;
using Compro_Intern.Daaataaa;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_TestProject
{
    [TestClass]
    public class InternTest2
    {
        private readonly IntContext _context;
        [TestMethod]
        public void WhrTest1()
        {
            //for working Hours
            IntWhrsController c = new IntWhrsController(_context);
            var a = c.GetIntWhr(1);
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void WhrTest2()
        {
            //for working Hours
            IntWhrsController c = new IntWhrsController(_context);
            var a = c.GetHrs();
            Assert.IsNotNull(a);
        }


    }
}
