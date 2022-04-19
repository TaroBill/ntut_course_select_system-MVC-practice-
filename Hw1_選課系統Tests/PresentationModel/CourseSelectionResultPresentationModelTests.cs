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
    public class CourseSelectionResultPresentationModelTests
    {
        private CourseSelectionResultPresentationModel _selectResult;
        private PrivateObject _courseSelectPrivate;

        //初始化選課結果表單PM
        [TestInitialize]
        public void Init()
        {
            BindingList<Course> allCourse = new BindingList<Course>();
            Course course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            Course course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            Course course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            Course course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            allCourse.Add(course1);
            allCourse.Add(course2);
            allCourse.Add(course3);
            allCourse.Add(course4);
            Data data = new Data() 
            {
                AllCourses = allCourse 
            };
            data.AddCourse(course2);
            data.AddCourse(course4);
            _selectResult = new CourseSelectionResultPresentationModel(data);
            _courseSelectPrivate = new PrivateObject(_selectResult);
        }

        //測試建構子
        [TestMethod()]
        public void TestCourseSelectionResultPresentationModel()
        {
        }

        //測試按下退選按鈕
        [TestMethod()]
        public void TestPressRemoveCourseButton()
        {
            Data data = (Data)_courseSelectPrivate.GetFieldOrProperty("_yourData");
            Assert.IsTrue(data.AllCourses.Count() == 4);
            Assert.IsTrue(data.YourCourse.Count() == 2);

            _selectResult.PressRemoveCourseButton(null, 0);
            Assert.IsTrue(data.YourCourse.Count() == 2);
            _selectResult.PressRemoveCourseButton(0, null);
            Assert.IsTrue(data.YourCourse.Count() == 2);
            _selectResult.PressRemoveCourseButton(null, null);
            Assert.IsTrue(data.YourCourse.Count() == 2);
            _selectResult.PressRemoveCourseButton(0, 1);
            Assert.IsTrue(data.AllCourses.Count() == 4);
            Assert.IsTrue(data.YourCourse.Count() == 1);
            _selectResult.PressRemoveCourseButton(1, 1);
            Assert.IsTrue(data.YourCourse.Count() == 1);
            _selectResult.PressRemoveCourseButton(1, 0);
            Assert.IsTrue(data.YourCourse.Count() == 1);
            _selectResult.PressRemoveCourseButton(0, 0);
            Assert.IsTrue(data.YourCourse.Count() == 0);
        }
    }
}