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
    public class CourseFormPresentationModelTests
    {
        private CourseFormPresentationModel _courseFormPresentationModel;
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        private Course _course5;

        //初始化
        [TestInitialize()]
        public void Init()
        {
            CourseWebCrawlerModel courseWebCrawlerModel = new CourseWebCrawlerModel();
            Data data = new Data();
            BindingList<Course> allCourse = new BindingList<Course>();
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            _course5 = new Course("41234", "測試課堂名稱三", "4", "3.0", "測試老師五", "測試必選修", "測試助教五", "測試語言五", "測試備註五", "4", "資工三");
            allCourse.Add(_course1);
            allCourse.Add(_course2);
            allCourse.Add(_course3);
            allCourse.Add(_course4);
            allCourse.Add(_course5);
            data.AllCourses = allCourse;
            _courseFormPresentationModel = new CourseFormPresentationModel(courseWebCrawlerModel, data);
            _courseFormPresentationModel.YourData.NotifyCourseObserver();
        }

        //測試刷新
        [TestMethod()]
        public void TestRefreshAllCourseList()
        {
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 3);
            _courseFormPresentationModel.CurrentTabPage = 1;
            _courseFormPresentationModel.RefreshAllCourseList();
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 2);
        }

        //確認有checkbox被選取
        [TestMethod()]
        public void TestIsCheckedCheckBox()
        {
            _courseFormPresentationModel.IsCheckedCheckBox();
            Assert.IsFalse(_courseFormPresentationModel.SendButtonEnable);
            _courseFormPresentationModel.CourseList[0][0] = "True";
            _courseFormPresentationModel.IsCheckedCheckBox();
            Assert.IsTrue(_courseFormPresentationModel.SendButtonEnable);
        }

        //設置所選的課是否被勾選
        [TestMethod()]
        public void TestSetCourseIsChoosed()
        {
            int? rowIndex = 0;
            Assert.IsTrue(_courseFormPresentationModel.CourseList[0][0] == "False");
            _courseFormPresentationModel.SetCourseIsChoosed(rowIndex, "True");
            Assert.IsTrue(_courseFormPresentationModel.CourseList[0][0] == "True");
            _courseFormPresentationModel.SetCourseIsChoosed(rowIndex, "False");
             rowIndex = null;
            _courseFormPresentationModel.SetCourseIsChoosed(rowIndex, "True");
            _courseFormPresentationModel.SetCourseIsChoosed(rowIndex, null);
            Assert.IsTrue(_courseFormPresentationModel.CourseList[0][0] == "False");
        }

        //測試有沒有成功加選
        [TestMethod()]
        public void TestAddToYourCourse()
        {
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 3);
            _courseFormPresentationModel.CourseList[1][0] = "True";
            _courseFormPresentationModel.CourseList[2][0] = "True";
            string result = _courseFormPresentationModel.AddToYourCourse();
            string expectResult = "同名:" + _course3.GetCourseInfo() + _course5.GetCourseInfo() + "\n";
            Assert.IsTrue(result == expectResult);
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 3);
            _courseFormPresentationModel.CourseList[2][0] = "False";
            result = _courseFormPresentationModel.AddToYourCourse();
            Assert.IsTrue("加選成功" == result);
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 2);
        }

        //測試將CourseList<string>轉回List<Course>
        [TestMethod()]
        public void TestGetCourseList()
        {
            List<Course> expectCourses = new List<Course>()
            {
                _course1,
                _course3,
                _course5,
            };
            List<Course> result =_courseFormPresentationModel.GetCourseList();
            Assert.IsTrue(expectCourses.Count() == result.Count());
            for (int resultIndex = 0; resultIndex < result.Count(); resultIndex++)
            {
                Assert.IsTrue(expectCourses[resultIndex].IsSameClass(result[resultIndex]));
            }
        }

        //測試將電子或資工加入CourseList
        [TestMethod()]
        public void TestAddCourse()
        {
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 3);
            _courseFormPresentationModel.AddCourse(1);
            Assert.IsTrue(_courseFormPresentationModel.CourseList.Count() == 2);
        }
    }
}