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

        [TestMethod, TestCategory("Constructor Time")]
        
        public void Constructor_Time_Hour()
        {
            Time.Time time = new Time.Time(8);
            
            Assert.AreEqual("8:00:00", time.ToString());
        }

        [TestMethod]
        public void Time_Equals()
        {
            Time.Time t1 = new Time.Time(8,15);
            Time.Time t2 = new Time.Time(8,15);

            Assert.IsTrue(t1.Equals(t2));
        }
    }
}
