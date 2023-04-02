using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2AssessmentQuestion1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssessmentQuestion1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LicensePlateTest()
        {
            Performance TPerformance = new Performance();
            TPerformance.LicensePlate("2WEin-ofnf", 4);
            string Expected = "2-WEIN-OF"; //2-WEIN-OFNF ==> correct test case
            Assert.AreEqual(Expected, TPerformance.newDmvNumber);
           
        }
    }
}