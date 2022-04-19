using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_選課系統;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統.Tests
{
    [TestClass()]
    public class StartUpFormPresentationModelTests
    {
        private StartUpFormPresentationModel _startUp;

        //初始化data
        [TestInitialize]
        public void Init()
        {
            _startUp = new StartUpFormPresentationModel();
        }

        //測試Button的getset
        [TestMethod()]
        public void TestStartUpFormPresentationModelButton()
        {
            Assert.IsTrue(_startUp.CourseManageButtonEnable);
            Assert.IsTrue(_startUp.CourseSelectButtonEnable);
            _startUp.CourseManageButtonEnable = false;
            _startUp.CourseSelectButtonEnable = false;
            Assert.IsFalse(_startUp.CourseManageButtonEnable);
            Assert.IsFalse(_startUp.CourseSelectButtonEnable);
            Assert.IsTrue(_startUp.YourData.YourCourse.Count() == 0);
        }
    }
}