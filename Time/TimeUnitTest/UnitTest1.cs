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

        #region Constructor Time==========================

        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_Default()
        {
            var time = new Time.Time();
            var defaultTime = new Time.Time(0, 00, 00);
            Assert.AreEqual(defaultTime, time);
        }

        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_ToString()
        {
            var t1 = new Time.Time();
            var t2 = new Time.Time(14, 53, 11);

            Assert.AreEqual("0:00:00", t1.ToString());
            Assert.AreEqual("14:53:11", t2.ToString());
        }

        [TestMethod, TestCategory("Constructor Time")]

        public void Constructor_Time_Hour()
        {
            Time.Time t1 = new Time.Time(8);
            Time.Time t2 = new Time.Time(11);

            Assert.AreEqual("8:00:00", t1.ToString());
            Assert.AreEqual("11:00:00", t2.ToString());
        }
        [TestMethod, TestCategory("Constructor Time")]

        public void Constructor_Time_Hour_Minutes()
        {
            Time.Time t1 = new Time.Time(8, 46);
            Time.Time t2 = new Time.Time(8, 46, 52);

            Assert.AreEqual("8:46:00", t1.ToString());
            Assert.AreEqual("8:46:52", t2.ToString());
        }

        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_Hour_Minutes_Seconsd()
        {
            Time.Time t1 = new Time.Time(8, 46, 35);
            Time.Time t2 = new Time.Time(23, 46, 15);

            Assert.AreEqual("8:46:35", t1.ToString());
            Assert.AreEqual("23:46:15", t2.ToString());
        }

        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_String_Hour()
        {
            Time.Time t1 = new Time.Time("12");
            Time.Time t2 = new Time.Time("23");

            Assert.AreEqual("12:00:00", t1.ToString());
            Assert.AreEqual("23:00:00", t2.ToString());
        }
        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_String_Hour_Minutes()
        {
            Time.Time t1 = new Time.Time("12:53");
            Time.Time t2 = new Time.Time("23:21");

            Assert.AreEqual("12:53:00", t1.ToString());
            Assert.AreEqual("23:21:00", t2.ToString());
        }
        [TestMethod, TestCategory("Constructor Time")]
        public void Constructor_Time_String_Hour_Minutes_Seconds()
        {
            Time.Time t1 = new Time.Time("12:21:02");
            Time.Time t2 = new Time.Time("23:53:33");

            Assert.AreEqual("12:21:02", t1.ToString());
            Assert.AreEqual("23:53:33", t2.ToString());
        }

        #endregion
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Equals()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15);
            Time.Time t3 = new Time.Time(8, 25, 53);

            Assert.IsTrue(t1.Equals(t2));
            Assert.IsFalse(t1.Equals(t3));
        }
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Operator_Equals()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15);
            Time.Time t3 = new Time.Time(15, 25, 53);

            Assert.IsTrue(t1 == t2);
            Assert.IsFalse(t1 == t3);
        }
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Operator_Smaller()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15, 44);
            Time.Time t3 = new Time.Time(12, 25, 53);

            Assert.IsTrue(t1 < t2);
            Assert.IsTrue(t1 < t3);
            Assert.IsFalse(t3 < t1);
        }
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Operator_Bigger()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15, 44);
            Time.Time t3 = new Time.Time(11, 25, 53);

            Assert.IsTrue(t2 > t1);
            Assert.IsTrue(t3 > t1);
            Assert.IsFalse(t1 > t3);
        }
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Operator_Smaller_Equals()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15);
            Time.Time t3 = new Time.Time(9, 25, 53);

            Assert.IsTrue(t1 <= t2);
            Assert.IsTrue(t1 <= t3);
            Assert.IsFalse(t3 <= t2);
        }
        [TestMethod, TestCategory("Equals Time")]
        public void Time_Operator_Bigger_Equals()
        {
            Time.Time t1 = new Time.Time(8, 15);
            Time.Time t2 = new Time.Time(8, 15);
            Time.Time t3 = new Time.Time(9, 25, 53);

            Assert.IsTrue(t2 >= t1);
            Assert.IsTrue(t3 >= t1);
            Assert.IsFalse(t2 >= t3);
        }
    }
}
