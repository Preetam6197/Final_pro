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
    public class InternTest3
    {
        private readonly IntContext _context;
        [TestMethod]
        public void LeavTest1()
        {
            //for Request Leaves
            IntReqlsController c = new IntReqlsController(_context);
            var a = c.GetIntReql(1);
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void LeavTest2()
        {
            //for Request Leaves
            IntReqlsController c = new IntReqlsController(_context);
            var a = c.GetLs();
            Assert.IsNotNull(a);
        }


    }
}
