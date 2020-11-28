using Microsoft.VisualStudio.TestTools.UnitTesting;
using Time;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace TimeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_Default()
        {
            var time = new Time.Time();
            var defaultTime = new Time.Time(0, 00, 00);
            Assert.AreEqual(defaultTime, time);
        }
        
        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_Default_ToString()
        {
            var time = new Time.Time();
            Assert.AreEqual("0:00:00", time.ToString());
        }
    }
}
