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
    public class CourseTests
    {
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        private Course _course;

        //初始化data
        [TestInitialize]
        public void Init()
        {
            string[] courseString = { "False", "20125", "課堂名稱", "2", "3.0", "1", "必選修", "老師", "", "", "", "1 2", "", "", "", "教室", "20", "10", "助教", "語言", "大綱", "備註", "隨班附讀", "實驗實習", "電子三" };
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "2", "電子三");
            _course = new Course(courseString);
        }

        //測試第一個建構子
        [TestMethod()]
        public void TestCourse()
        {
            Course course5 = new Course("5", "測試課堂名稱五", "3", "2.0", "測試老師五", "測試必選修", "測試助教五", "測試語言五", "測試備註五", "1", "資工三");
            Assert.IsTrue(course5.Number == "5");
            Assert.IsTrue(course5.Name == "測試課堂名稱五");
            Assert.IsTrue(course5.Stage == "3");
            Assert.IsTrue(course5.Credit == "2.0");
            Assert.IsTrue(course5.Teacher == "測試老師五");
            Assert.IsTrue(course5.ClassType == "測試必選修");
            Assert.IsTrue(course5.Assistance == "測試助教五");
            Assert.IsTrue(course5.Language == "測試語言五");
            Assert.IsTrue(course5.Note == "測試備註五");
            Assert.IsTrue(course5.Hour == "1");
            Assert.IsTrue(course5.Class == "資工三");
            Assert.IsTrue(course5.Audit == "");
            Assert.IsTrue(course5.Experiment == "");
            Assert.IsTrue(course5.Syllabus == "");
        }

        //測試第三個建構子
        [TestMethod()]
        public void TestCourse2()
        {
            Assert.IsTrue(_course.Number == "20125");
            Assert.IsTrue(_course.Name == "課堂名稱");
            Assert.IsTrue(_course.Stage == "2");
            Assert.IsTrue(_course.Credit == "3.0");
            Assert.IsTrue(_course.Teacher == "老師");
            Assert.IsTrue(_course.ClassType == "必選修");
            Assert.IsTrue(_course.Assistance == "助教");
            Assert.IsTrue(_course.Language == "語言");
            Assert.IsTrue(_course.Note == "備註");
            Assert.IsTrue(_course.Hour == "1");
            Assert.IsTrue(_course.Class == "電子三");
            Assert.IsTrue(_course.Audit == "隨班附讀");
            Assert.IsTrue(_course.Experiment == "實驗實習");
            Assert.IsTrue(_course.Syllabus == "大綱");
            Assert.IsTrue(_course.ClassTimeWednesday == "1 2");
            Assert.IsTrue(_course.ClassTimeFriday == "");
            Assert.IsTrue(_course.Classroom == "教室");
            Assert.IsTrue(_course.NumberOfDropStudent == "10");
            Assert.IsTrue(_course.NumberOfStudent == "20");
        }

        //測試Course轉成string[]的結果是否正確
        [TestMethod()]
        public void TestConvertToStringList()
        {
            string[] courseString = { "False", "20125", "課堂名稱", "2", "3.0", "1", "必選修", "老師", "", "", "", "1 2", "", "", "", "教室", "20", "10", "助教", "語言", "大綱", "備註", "隨班附讀", "實驗實習", "電子三" };
            string[] courseStringConverted = _course.ConvertToStringList();
            for (int index = 0; index < courseString.Length; index++)
                Assert.IsTrue(courseStringConverted[index] == courseString[index]);
        }

        //測試是否衝堂
        [TestMethod()]
        public void TestIsClassConflict()
        {
            Assert.IsFalse(_course1.IsClassConflict(_course2));
            Assert.IsFalse(_course1.IsClassConflict(_course4));
            _course3.ClassTimeWednesday = "1";
            _course3.ClassTimeThursday = "";
            _course4.ClassTimeWednesday = "1 2";
            Assert.IsTrue(_course3.IsClassConflict(_course));
            Assert.IsTrue(_course4.IsClassConflict(_course));
            _course3.ClassTimeWednesday = "N 5";
            _course3.ClassTimeMonday = "N";
            _course3.ClassTimeTuesday = "A";
            _course3.ClassTimeFriday = "";
            _course3.ClassTimeSaturday = "1 3 C";
            _course3.ClassTimeSunday = "C";
            Assert.IsFalse(_course3.IsClassConflict(_course));
        }

        //測試課名是否重複
        [TestMethod()]
        public void TestIsSameName()
        {
            Assert.IsFalse(_course1.IsSameName(_course2));
            Assert.IsFalse(_course1.IsSameName(_course4));
            _course3.Name = _course4.Name;
            _course1.Name = "課堂名稱";
            Assert.IsTrue(_course3.IsSameName(_course4));
            Assert.IsTrue(_course1.IsSameName(_course));
            _course2.Name = "";
            _course1.Name = "";
            Assert.IsTrue(_course1.IsSameName(_course2));
        }

        //測試輸出課程資訊是否正確
        [TestMethod()]
        public void TestGetCourseInfo()
        {
            const string courseInfo = "「1-測試課堂名稱一」";
            Assert.IsTrue(courseInfo == _course1.GetCourseInfo());
        }

        //測試將課堂時間分離成string[] "1 2" => {"1", "2"}
        [TestMethod()]
        public void TestSplitClassTime()
        {
            string[] result = _course.SplitClassTime(3);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == "1");
            Assert.IsTrue(result[1] == "2");
            _course.ClassTime[0] = "5";
            result = _course.SplitClassTime(0);
            Assert.IsTrue(result.Length == 1);
            Assert.IsTrue(result[0] == "5");
            _course.ClassTime[1] = "";
            result = _course.SplitClassTime(1);
            Assert.IsTrue(result.Length == 1);
            Assert.IsTrue(result[0] == "");
        }

        //測試ClassTimePeriods
        [TestMethod()]
        public void TestClassTimePeriods()
        {
            BindingList<ClassTimePeriod> periods = new BindingList<ClassTimePeriod>();
            for (int periodIndex = 0; periodIndex < 14; periodIndex++)
                periods.Add(new ClassTimePeriod(Course.ConvertPeriodIntegerToString(periodIndex)));
            _course.ClassTimePeriods(periods);
            Assert.IsTrue(periods[0].Wednesday == true);
            Assert.IsTrue(periods[1].Wednesday == true);
            for (int periodIndex = 0; periodIndex < 14; periodIndex++)
            {
                if (periodIndex <= 1)
                    Assert.IsTrue(periods[periodIndex].Wednesday);
                else
                    Assert.IsFalse(periods[periodIndex].Wednesday);
                Assert.IsFalse(periods[periodIndex].Sunday);
                Assert.IsFalse(periods[periodIndex].Monday);
                Assert.IsFalse(periods[periodIndex].Tuesday);
                Assert.IsFalse(periods[periodIndex].Thursday);
                Assert.IsFalse(periods[periodIndex].Friday);
                Assert.IsFalse(periods[periodIndex].Saturday);
            }
        }

        //測試兩堂課是否為同一堂，根據所有資料測試
        [TestMethod()]
        public void TestIsSameClass()
        {
            string[] courseString = { "False", "20125", "課堂名稱", "2", "3.0", "1", "必選修", "老師", "", "", "", "1 2", "", "", "", "教室", "20", "10", "助教", "語言", "大綱", "備註", "隨班附讀", "實驗實習", "電子三" };
            Course course = new Course(courseString);
            Assert.IsTrue(course.IsSameClass(_course));
            _course.Name = "課程測試";
            Assert.IsFalse(course.IsSameClass(_course));
            Assert.IsFalse(course.IsSameClass(_course1));
        }

        //測試兩堂課是否為同一堂，根據課號測試
        [TestMethod()]
        public void TestIsSameClass1()
        {
            Assert.IsFalse(_course.IsSameClass(_course1.Number));
            _course1.Number = _course.Number;
            Assert.IsTrue(_course.IsSameClass(_course1.Number));
            Assert.IsFalse(_course.IsSameClass(_course2.Number));
        }

        //測試所有必填資料是否已經填入
        [TestMethod()]
        public void TestIsAllNecessary()
        {
            Assert.IsTrue(_course.IsAllNecessary());
            Course courseNotFull = new Course("", "Name", "3", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Number
            courseNotFull = new Course("12345", "", "3", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Name
            courseNotFull = new Course("12345", "Name", "", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Stage
            courseNotFull = new Course("12345", "Name", "2", "", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Credit
            courseNotFull = new Course("12345", "Name", "2", "3.0", "", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Teacher
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "", "助教", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試ClassType
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "測試必選修", "", "測試語言三", "測試備註三", "3", "資工三");
            Assert.IsTrue(courseNotFull.IsAllNecessary());//測試Assistance
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "測試必選修", "助教", "", "測試備註三", "3", "資工三");
            Assert.IsTrue(courseNotFull.IsAllNecessary());//測試Language
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "", "3", "資工三");
            Assert.IsTrue(courseNotFull.IsAllNecessary());//測試Note
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "", "資工三");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試Hour
            courseNotFull = new Course("12345", "Name", "2", "3.0", "測試老師三", "測試必選修", "助教", "測試語言三", "測試備註三", "3", "");
            Assert.IsFalse(courseNotFull.IsAllNecessary());//測試開課班級
        }

        //測試將令一堂課的所有必填資料複製到此堂課
        [TestMethod()]
        public void TestCopyNecessaryData()
        {
            Assert.IsFalse(_course.IsSameClass(_course1));
            _course.CopyNecessaryData(_course1);
            Assert.IsTrue(_course.IsSameClass(_course1));
        }

        //測試將課堂時間的字串轉成數字(N->5)(A->10)(B->11)(C->12)(D->13)
        [TestMethod()]
        public void TestConvertPeriodStringToInteger()
        {
            for (int index = 1; index < 5; index++)
                Assert.IsTrue(Course.ConvertPeriodStringToInteger(index.ToString()) == index - 1);
            Assert.IsTrue(Course.ConvertPeriodStringToInteger("N") == 4);
            for (int index = 5; index < 10; index++)
                Assert.IsTrue(Course.ConvertPeriodStringToInteger(index.ToString()) == index);
            Assert.IsTrue(Course.ConvertPeriodStringToInteger("A") == 10);
            Assert.IsTrue(Course.ConvertPeriodStringToInteger("B") == 11);
            Assert.IsTrue(Course.ConvertPeriodStringToInteger("C") == 12);
            Assert.IsTrue(Course.ConvertPeriodStringToInteger("D") == 13);
            Assert.IsFalse(Course.ConvertPeriodStringToInteger("4") == 4);
        }

        //測試將課堂時間的數字轉成字串
        [TestMethod()]
        public void TestConvertPeriodIntegerToString()
        {
            for (int index = 0; index < 4; index++)
                Assert.IsTrue(Course.ConvertPeriodIntegerToString(index) == (index + 1).ToString());
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(4) == "N");
            for (int index = 5; index < 10; index++)
                Assert.IsTrue(Course.ConvertPeriodIntegerToString(index) == index.ToString());
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(10) == "A");
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(11) == "B");
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(12) == "C");
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(13) == "D");
            Assert.IsTrue(Course.ConvertPeriodIntegerToString(14) == "");
            Assert.IsFalse(Course.ConvertPeriodIntegerToString(0) == "0");
        }

        //測試將datagridview的classTime轉換成Course所儲存的方式
        [TestMethod()]
        public void TestConvertClassTimeStyle()
        {
            List<ClassTimePeriod> periods = new List<ClassTimePeriod>();
            for (int periodIndex = 0; periodIndex < 14; periodIndex++)
                periods.Add(new ClassTimePeriod(Course.ConvertPeriodIntegerToString(periodIndex)));
            periods[0].Monday = true;
            periods[0].Wednesday = true;
            periods[1].Wednesday = true;
            periods[13].Friday = true;
            _course1.ConvertClassTimeStyle(periods);
            Assert.IsTrue(_course1.ClassTimeSunday == "");
            Assert.IsTrue(_course1.ClassTimeMonday == "1");
            Assert.IsTrue(_course1.ClassTimeTuesday == "");
            Assert.IsTrue(_course1.ClassTimeWednesday == "1 2");
            Assert.IsTrue(_course1.ClassTimeThursday == "");
            Assert.IsTrue(_course1.ClassTimeFriday == "D");
            Assert.IsTrue(_course1.ClassTimeSaturday == "");
            periods[0].Monday = false;
            periods[13].Friday = false;
            Assert.IsFalse(_course2.ClassTimeWednesday == _course.ClassTimeWednesday);
            _course2.ConvertClassTimeStyle(periods);
            Assert.IsTrue(_course2.ClassTimeWednesday == _course.ClassTimeWednesday);
        }

        //測試將List加入BindingList
        [TestMethod()]
        public void TestAddListToBindingList()
        {
            BindingList<Course> allCourses = new BindingList<Course>() { _course4 };
            List<Course> addCourses = new List<Course>() { _course3, _course1 };
            Assert.IsTrue(allCourses.Count() == 1);
            Course.AddListToBindingList(allCourses, addCourses);
            Assert.IsTrue(allCourses.Count() == 3);
            Assert.IsTrue(allCourses[0].IsSameClass(_course4));
            Assert.IsTrue(allCourses[1].IsSameClass(_course3));
            Assert.IsTrue(allCourses[2].IsSameClass(_course1));
        }
    }
}