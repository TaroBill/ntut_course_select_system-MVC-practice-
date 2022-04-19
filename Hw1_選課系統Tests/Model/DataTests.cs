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
    public class DataTests
    {
        private Data _data;
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        private PrivateObject _dataPrivate;

        //初始化data
        [TestInitialize]
        public void Init()
        {
            _data = new Data();
            BindingList<Course> allCourse = new BindingList<Course>();
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            _data.AddClass("資工三");
            _data.AddClass("電子三");
            allCourse.Add(_course1);
            allCourse.Add(_course2);
            allCourse.Add(_course3);
            allCourse.Add(_course4);
            _data.AllCourses = allCourse;
            _dataPrivate = new PrivateObject(_data);
        }

        //測試爬蟲並將所有開課班級加入AllCourse
        [TestMethod()]
        public void TestAddDataToAllCourse()
        {
            _data.AllCourses = new BindingList<Course>();
            _data.AddDataToAllCourse();
            Console.WriteLine(_data.AllCourses.Count());
            Assert.IsTrue(_data.AllCourses.Count() == 36);
            _data.AllCourses = new BindingList<Course>();

            Assert.IsTrue(_data.AllClasses.Count() == 2);
            _data.AddClass("資工一");
            Assert.IsTrue(_data.AllClasses.Count() == 3);
            _data.AddDataToAllCourse(2);
            Assert.IsTrue(_data.AllCourses.Count() == 36);
        }

        //測試加入所有資工
        [TestMethod()]
        public void TestAddComputerScience()
        {
            Assert.IsTrue(_data.AllClasses.Count() == 2);
            _data.AddComputerScience();
            Assert.IsTrue(_data.AllClasses.Count() == 6);
            _data.AddComputerScience();
            Assert.IsTrue(_data.AllClasses.Count() == 6);
        }

        //測試設定開課班級
        [TestMethod()]
        public void TestSetClass()
        {
            List<Course> courses = new List<Course>() { _course3, _course1, _course2 };
            courses = (List<Course>)_dataPrivate.Invoke("SetClass", "未知班級", courses);
            Assert.IsTrue(courses.Count() == 3);
            foreach (Course course in courses)
                Assert.IsTrue(course.Class == "未知班級");
        }

        //測試GetData
        [TestMethod()]
        public void TestGetData()
        {
            List<Course> courses = _data.GetData("https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433");
            Assert.IsTrue(courses.Count() == 12);
            Assert.IsTrue(courses[0].Name == "班週會及導師時間");
            Assert.IsTrue(courses[1].Number == "291702");
            Assert.IsTrue(courses[1].Name == "體育");
            Assert.IsTrue(courses[1].Stage == "5");
            Assert.IsTrue(courses[1].Credit == "0.0");
            Assert.IsTrue(courses[1].Hour == "2");
            Assert.IsTrue(courses[1].Note == "*");
            Assert.IsTrue(courses[1].Experiment == "");
            int last = courses.Count() - 1;
            Assert.IsTrue(courses[last].Number == "294329");
            Assert.IsTrue(courses[last].Name == "數位影像處理");
            Assert.IsTrue(courses[last].Stage == "1");
            Assert.IsTrue(courses[last].Credit == "3.0");
            Assert.IsTrue(courses[last].Hour == "3");
            Assert.IsTrue(courses[last].Note == "◎資工三、四資四和資工所合開");
            Assert.IsTrue(courses[last].Experiment == "");
        }

        //測試成功呼叫Observer
        [TestMethod()]
        public void TestNotifyCourseObserver()
        {
            try
            {
                _data.NotifyCourseObserver();
            }
            catch
            {
                Assert.Fail();
            }
            _data.CourseChanged += TestObserver;
            try
            {
                _data.NotifyCourseObserver();
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.IsTrue(exception.Message == "成功呼叫");
            }
        }

        //測試成功呼叫Observer
        [TestMethod()]
        public void TestNotifyDone()
        {
            try
            {
                _data.NotifyDone();
            }
            catch
            {
                Assert.Fail();
            }
            _data.Done += TestObserver;
            try
            {
                _data.NotifyDone();
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

        //測試從allCourse裡加入Course到yourCourse裡，若allCourse找不到則不加入
        [TestMethod()]
        public void TestAddCourse()
        {
            Course course5 = new Course("5", "測試課堂名稱五", "1", "3.0", "測試老師五", "測試必選修", "測試助教五", "測試語言五", "測試備註五", "3", "資工三");
            _data.AddCourse(_course3);
            _data.AddCourse(_course2);
            List<int> yourCourseIndex = (List<int>)_dataPrivate.GetFieldOrProperty("_yourCourseInAllCourseIndex");
            Assert.IsTrue(yourCourseIndex.Count() == 2);
            Assert.IsFalse(yourCourseIndex[0] == 0);
            Assert.IsTrue(yourCourseIndex[1] == 1);
            _data.AddCourse(course5);
            yourCourseIndex = (List<int>)_dataPrivate.GetFieldOrProperty("_yourCourseInAllCourseIndex");
            Assert.IsTrue(yourCourseIndex.Count() == 2);
        }

        //測試從yourCourse裡移除course
        [TestMethod()]
        public void TestRemoveCourseAt()
        {
            _data.AddCourse(_course1);
            _data.AddCourse(_course3);
            _data.AddCourse(_course2);
            List<int> yourCourseIndex = (List<int>)_dataPrivate.GetFieldOrProperty("_yourCourseInAllCourseIndex");
            Assert.IsTrue(yourCourseIndex.Count() == 3);
            Assert.IsTrue(yourCourseIndex[1] == 2);
            _data.RemoveCourseAt(1);
            Assert.IsTrue(yourCourseIndex.Count() == 2);
            Assert.IsTrue(yourCourseIndex[1] == 1);
            _data.RemoveCourseAt(3);
            Assert.IsTrue(yourCourseIndex.Count() == 2);
            Assert.IsTrue(yourCourseIndex[0] == 0);
            _data.RemoveCourseAt(-1);
            Assert.IsTrue(yourCourseIndex.Count() == 2);
            Assert.IsTrue(yourCourseIndex[1] == 1);

        }

        //測試成功把輸入的Courses和yourCourse重複元素刪掉
        [TestMethod()]
        public void TestDeleteSameCourse()
        {
            Course course5 = new Course("5", "測試課堂名稱五", "1", "3.0", "測試老師五", "測試必選修", "測試助教五", "測試語言五", "測試備註五", "3", "資工三");
            List<string[]> computerScienceAllCourse = new List<string[]>() { _course1.ConvertToStringList(), _course3.ConvertToStringList(), course5.ConvertToStringList() };
            _data.AllCourses.Add(course5);
            _data.AddCourse(course5);
            _data.AddCourse(_course2);
            List<string[]> result = _data.DeleteSameCourse(computerScienceAllCourse);
            Assert.IsTrue(result.Count() == 2);
            Assert.IsTrue(IsSameCourse(result[0], _course1.ConvertToStringList()));
            Assert.IsTrue(IsSameCourse(result[1], _course3.ConvertToStringList()));
            computerScienceAllCourse[0][(int)Course.Index.IsOpened + 1] = "未開課";
            result = _data.DeleteSameCourse(computerScienceAllCourse);
            Assert.IsTrue(result.Count() == 1);
            Assert.IsTrue(IsSameCourse(result[0], _course3.ConvertToStringList()));
        }

        //測試成功獲取yourCourse的所有course
        [TestMethod()]
        public void TestGetYourCourse()
        {
            _data.AddCourse(_course2);
            _data.AddCourse(_course3);
            Assert.IsTrue(_data.YourCourse[0].IsSameClass(_course2));
            Assert.IsTrue(_data.YourCourse[1].IsSameClass(_course3));
            Assert.IsFalse(_data.YourCourse[1].IsSameClass(_course4));
        }

        //測試整個List<Course>轉為 List<string[]>
        [TestMethod()]
        public void CourseListToStringListTest()
        {
            List<string[]> result = (List<string[]>)_dataPrivate.Invoke("CourseListToStringList", _data.AllCourses.ToList<Course>());
            Assert.IsTrue(IsSameCourse(_course1.ConvertToStringList(), result[0]));
            Assert.IsFalse(IsSameCourse(_course2.ConvertToStringList(), result[2]));
            Assert.IsFalse(IsSameCourse(_course3.ConvertToStringList(), result[1]));
            Assert.IsTrue(IsSameCourse(_course4.ConvertToStringList(), result[3]));
        }

        //測試根據模式回傳不包括已選的班級
        [TestMethod()]
        public void TestGetUnchooseCourse()
        {
            List<string[]> computerScienceList = new List<string[]>() { _course1.ConvertToStringList(), _course3.ConvertToStringList() };
            List<string[]> testListFromData = _data.GetUnchooseCourse(0);
            Assert.IsTrue(IsSameCourse(computerScienceList[0], testListFromData[0]));
            Assert.IsTrue(IsSameCourse(computerScienceList[1], testListFromData[1]));
            List<string[]> eletronicScienceList = new List<string[]>() { _course2.ConvertToStringList(), _course4.ConvertToStringList() };
            testListFromData = _data.GetUnchooseCourse(1);
            Assert.IsTrue(IsSameCourse(eletronicScienceList[0], testListFromData[0]));
            Assert.IsTrue(IsSameCourse(eletronicScienceList[1], testListFromData[1]));
            Assert.IsFalse(IsSameCourse(computerScienceList[0], testListFromData[0]));
            Assert.IsFalse(IsSameCourse(new string[] { "false", "1", "名稱" }, testListFromData[0]));
            testListFromData = _data.GetUnchooseCourse(100);
            Assert.IsTrue(IsSameCourse(computerScienceList[0], testListFromData[0]));
            Assert.IsTrue(IsSameCourse(computerScienceList[1], testListFromData[1]));
        }

        //測試兩個字串型態的course是否為相同
        private bool IsSameCourse(string[] course1, string[] course2)
        {
            if (course1.Length != course2.Length)
                return false;
            for (int index = 0; index < course1.Length; index ++)
            {
                if (course1[index] != course2[index])
                    return false;
            }
            return true;
        }

        //test
        [TestMethod()]
        public void TestGetAllClassesNameList()
        {
            string[] expectValue = { "資工三", "電子三" };
            for (int index = 0; index < expectValue.Length; index++)
                Assert.AreEqual(expectValue[index], _data.AllClassesNameList[index]);
        }

        //加入一個課程
        [TestMethod()]
        public void TestAddClass()
        {
            Assert.IsTrue(_data.AllClasses.Count() == 2);
            _data.AddClass("資工三");//重複加入課程
            Assert.IsTrue(_data.AllClasses.Count() == 2);
            _data.AddClass("資工二");
            Assert.IsTrue(_data.AllClasses.Count() == 3);
            string[] expectValue = { "資工三", "電子三", "資工二" };
            for (int index = 0; index < expectValue.Length; index++)
                Assert.AreEqual(expectValue[index], _data.AllClassesNameList[index]);
        }

        //輸入開課班級尋找所有同班級的資料
        [TestMethod()]
        public void TestGetCoursesNameByClassName()
        {
            List<string> result = _data.GetCoursesNameByClassName("資工三");
            Assert.IsTrue(result.Count() == 2);
            Assert.AreEqual(result[0], _course1.Name);
            Assert.AreEqual(result[1], _course3.Name);
        }
    }
}