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
    public class ImportCourseProgressFormPresentationModelTests
    {
        ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        //初始化data
        [TestInitialize]
        public void Initialize()
        {
            Data data = new Data();
            BindingList<Course> allCourse = new BindingList<Course>();
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            allCourse.Add(_course1);
            allCourse.Add(_course2);
            allCourse.Add(_course3);
            allCourse.Add(_course4);
            data.AllCourses = allCourse;
            _importCourseProgressFormPresentationModel = new ImportCourseProgressFormPresentationModel(data);
        }

        //測試成功呼叫Observer
        [TestMethod()]
        public void TestNotifyProgressObserver()
        {
            try
            {
                _importCourseProgressFormPresentationModel.NotifyProgressObserver();
            }
            catch
            {
                Assert.Fail();
            }
            _importCourseProgressFormPresentationModel.ProgressChanged += TestObserver;
            try
            {
                _importCourseProgressFormPresentationModel.NotifyProgressObserver();
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.IsTrue(exception.Message == "成功呼叫");
            }
        }

        //測試有沒有成功呼叫到observer pattern
        private void TestObserver()
        {
            throw new Exception("成功呼叫");
        }

        //測試加入所有資工
        [TestMethod()]
        public void TestAddComputerScienceCourse()
        {
            Assert.IsTrue(_importCourseProgressFormPresentationModel.YourData.AllClasses.Count() == 2);
            _importCourseProgressFormPresentationModel.AddComputerScienceCourse();
            Assert.IsTrue(_importCourseProgressFormPresentationModel.YourData.AllClasses.Count() == 6);
        }

        //測試設置進度條
        [TestMethod()]
        public void TestSetProgressFromData()
        {
            _importCourseProgressFormPresentationModel.YourData.NowProgress = 1;
            _importCourseProgressFormPresentationModel.YourData.Total = 10;
            _importCourseProgressFormPresentationModel.SetProgressFromData();
            Assert.IsTrue(_importCourseProgressFormPresentationModel.NowProgressLabelText == "10%");
        }
    }
}