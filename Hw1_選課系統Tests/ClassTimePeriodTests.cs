using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_選課系統;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Homework_選課系統.Tests
{
    [TestClass()]
    public class ClassTimePeriodTests
    {
        private BindingList<ClassTimePeriod> _periods;

        //初始化data
        [TestInitialize]
        public void Init()
        {
            _periods = new BindingList<ClassTimePeriod>();
            for (int periodIndex = 0; periodIndex < 14; periodIndex++)
                _periods.Add(new ClassTimePeriod(Course.ConvertPeriodIntegerToString(periodIndex)));
            _periods[0].Monday = true;
            _periods[1].Tuesday = true;
            _periods[2].Wednesday = true;
            _periods[3].Thursday = true;
            _periods[4].Friday = true;
            _periods[5].Saturday = true;
            _periods[6].Sunday = true;
            _periods[0].Thursday = true;
            _periods[0].Saturday = true;
            _periods[0].Sunday = true;
        }

        //測試建構子
        [TestMethod()]
        public void TestClassTimePeriod()
        {
            ClassTimePeriod period = new ClassTimePeriod("1");
            Assert.IsTrue(period.Period == "1");
            period.Period = "N";
            Assert.IsTrue(period.Period == "N");
            for (int weekIndex = 0; weekIndex < 7; weekIndex++)
                Assert.IsFalse(period.ClassTime[weekIndex]);
        }

        //測試該節課在一周內有多少時數
        [TestMethod()]
        public void TestTotalClassTime()
        {
            Assert.IsTrue(_periods[0].TotalClassTime() == 4);
            Assert.IsTrue(_periods[1].TotalClassTime() == 1);
            Assert.IsTrue(_periods[7].TotalClassTime() == 0);
            _periods[7].ClassTime = new bool[7] { true, false, true, false, false, true, false };
            Assert.IsTrue(_periods[7].TotalClassTime() == 3);
        }

        //測試有沒有成功重製所有課堂時數
        [TestMethod()]
        public void TestResetAllPeriod()
        {
            Assert.IsTrue(_periods[0].TotalClassTime() == 4);
            _periods[0].ResetAllPeriod();
            Assert.IsTrue(_periods[0].TotalClassTime() == 0);
        }
    }
}