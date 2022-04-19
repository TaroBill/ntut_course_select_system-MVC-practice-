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
    public class CourseWebCrawlerModelTests
    {
        private CourseWebCrawlerModel _courseWebCrawlerModel;
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;

        //初始化課程管理PM
        [TestInitialize()]
        public void Init()
        {
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            _course1.ClassTimeMonday = "1 2";
            _course2.ClassTimeFriday = "N A";
            _course3.ClassTimeSaturday = "4 5";
            _course4.ClassTimeMonday = "2 3";
            _course4.ClassTimeSunday = "1";
            _courseWebCrawlerModel = new CourseWebCrawlerModel();
        }

        //根據輸入的課程判斷式將兩個List中相同課程加入輸出List
        [TestMethod()]
        public void TestCheckCourseDuplicate()
        {
            List<Course> courses1 = new List<Course>()
            {
                _course1,
                _course2
            };
            List<Course> courses2 = new List<Course>()
            {
                _course3,
                _course2,
                _course4
            };
            bool conflict(Course course1, Course course2) => course1.IsClassConflict(course2);
            List<Course> result = _courseWebCrawlerModel.CheckCourseDuplicate(courses1, courses2, conflict);
            Assert.IsTrue(result.Count() == 2);
            Assert.IsTrue(result[0].IsSameClass(_course1));
            Assert.IsTrue(result[1].IsSameClass(_course4));
        }

        //測試回傳所有衝堂的課程名稱，若沒有則回傳空字串;
        [TestMethod()]
        public void TestConflictCourses()
        {
            Course course = new Course("1", "測試課堂名稱四", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            List<Course> courses1 = new List<Course>()
            {
                _course1,
                _course2,
                course
            };
            List<Course> courses2 = new List<Course>()
            {
                _course3,
                _course2,
                _course4
            };
            string result = _courseWebCrawlerModel.ConflictCourses(courses1, courses2, 0);
            string expectResult = "衝堂:" + _course1.GetCourseInfo() + _course4.GetCourseInfo() + "\n";
            Assert.IsTrue(expectResult == result);
            result = _courseWebCrawlerModel.ConflictCourses(courses1, courses2, 1);
            expectResult = "同名:" + course.GetCourseInfo() + _course4.GetCourseInfo() + "\n";
            Assert.IsTrue(expectResult == result);
            result = _courseWebCrawlerModel.ConflictCourses(courses1, courses2, 3);
            Assert.IsTrue("" == result);
            courses1.RemoveAt(2);
            result = _courseWebCrawlerModel.ConflictCourses(courses1, courses2, 1);
            Assert.IsTrue("" == result);
        }

        //測試回傳衝堂或重複的課
        [TestMethod()]
        public void TestCourseConflictResult()
        {
            Course course = new Course("1", "測試課堂名稱四", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            List<string[]> courseList = new List<string[]>() 
            {
                _course1.ConvertToStringList(),
                _course2.ConvertToStringList(),
                course.ConvertToStringList(),
            };
            courseList[0][0] = "True";
            courseList[2][0] = "True";
            List<Course> courses2 = new List<Course>()
            {
                _course3,
                _course2,
                _course4
            };
            string result = _courseWebCrawlerModel.CourseConflictResult(courseList, courses2);
            string expectResult = "衝堂:" + _course1.GetCourseInfo() + _course4.GetCourseInfo() + "\n" + "同名:" + course.GetCourseInfo() + _course4.GetCourseInfo() + "\n";
            Assert.IsTrue(expectResult == result);
            courses2.RemoveAt(2);
            result = _courseWebCrawlerModel.CourseConflictResult(courseList, courses2);
            Assert.IsTrue("" == result);
        }
    }
}