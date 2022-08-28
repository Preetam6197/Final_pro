using Compro_Intern.Controllers;
using Compro_Intern.Daaataaa;
using Compro_Intern.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Intern_TestProject
{
    [TestClass]
    public class InternTes1
    {
        private readonly IntContext _context;
        public IntDesg d;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("tialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("sCleanup");
        }

        [TestMethod]
        public void Test_1()
        {
            Console.WriteLine("Helo test mthd 1");
        }
        [TestMethod]
        public void TestMethodInt1()
        {
            //Test Method for checking Designation of intern 
           
            IntDesgsController c = new IntDesgsController( _context);
            var a = c.GetIntDesg(1);
            Assert.IsNotNull(a);



        }


        [TestMethod]
        public void TestMethodInt2()
        {

            IntDesgsController c = new IntDesgsController(_context);
            var a = c.GetDesgs();
            Assert.IsNotNull(a);




        }


        [TestMethod]
        public void WhrTest1()
        {

            IntWhrsController c = new IntWhrsController(_context);
            var a = c.GetIntWhr(1);
            Assert.IsNotNull(a);




        }

        IntWhrsController

    }
}
