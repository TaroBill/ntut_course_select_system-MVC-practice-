using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_選課系統;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Homework_選課系統.Tests
{
    [TestClass()]
    public class CourseManageFormPresentationModelTests
    {
        private CourseManageFormPresentationModel _courseManage;
        private Course _course1;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        private PrivateObject _courseManagePrivate;


        //初始化課程管理PM
        [TestInitialize()]
        public void Init()
        {
            BindingList<Course> allCourse = new BindingList<Course>();
            _course1 = new Course("1", "測試課堂名稱一", "1", "1.0", "測試老師一", "測試必選修", "測試助教一", "測試語言一", "測試備註一", "1", "資工三");
            _course2 = new Course("2", "測試課堂名稱二", "2", "2.0", "測試老師二", "測試必選修", "測試助教二", "測試語言二", "測試備註二", "2", "電子三");
            _course3 = new Course("3", "測試課堂名稱三", "3", "3.0", "測試老師三", "測試必選修", "測試助教三", "測試語言三", "測試備註三", "3", "資工三");
            _course4 = new Course("4", "測試課堂名稱四", "4", "3.0", "測試老師四", "測試必選修", "測試助教四", "測試語言四", "測試備註三", "4", "電子三");
            _course1.ClassTimeMonday = "1 2";
            _course2.ClassTimeFriday = "N A";
            _course2.ClassTimeSaturday = "4 5";
            allCourse.Add(_course1);
            allCourse.Add(_course2);
            allCourse.Add(_course3);
            allCourse.Add(_course4);
            Data data = new Data()
            {
                AllCourses = allCourse
            };
            data.AddClass("資工三");
            data.AddClass("電子三");
            _courseManage = new CourseManageFormPresentationModel(data);
            _courseManagePrivate = new PrivateObject(_courseManage);
        }

        //測試建構子
        [TestMethod()]
        public void TestCourseManageFormPresentationModel()
        {
            _courseManage.ButtonChangedEnable += GetNotify;
            try
            {
                _courseManage.SaveButtonEnable = false;
                Assert.Fail();
            }
            catch(Exception exception)
            {
                Assert.IsTrue(exception.Message == "成功獲取到通知");
            }
            Assert.IsFalse(_courseManage.SaveButtonEnable);
        }

        //測試獲取到通知用funtion
        private void GetNotify()
        {
            throw new Exception("成功獲取到通知");
        }

        //測試將classTime中的x-y設值
        [TestMethod()]
        public void TestSetClassTimeEnable()
        {
            Assert.IsFalse(_courseManage.ClassTime[2].ClassTime[0]);
            _courseManage.SetClassTimeEnable(new Point(1,2), true);
            Assert.IsTrue(_courseManage.ClassTime[2].ClassTime[0]);
            try
            {
                _courseManage.SetClassTimeEnable(null, true);
                _courseManage.SetClassTimeEnable(null, null);
                _courseManage.SetClassTimeEnable(new Point(1, 2), null);
                Assert.IsTrue(_courseManage.ClassTime[2].ClassTime[0]);
            }
            catch
            {
                Assert.Fail();
            }
        }

        //測試讀出該堂課的classTime並轉成datagridview顯示狀態
        [TestMethod()]
        public void TestLoadCourseClassTimeToDataGridView()
        {
            _courseManage.LoadCourseClassTimeToDataGridView(0);
            Assert.IsTrue(_courseManage.ClassTime[0].Monday);
            Assert.IsTrue(_courseManage.ClassTime[1].Monday);
            Assert.IsFalse(_courseManage.ClassTime[2].Monday);
            Assert.IsFalse(_courseManage.ClassTime[4].Friday);
            Assert.IsFalse(_courseManage.ClassTime[10].Friday);
            Assert.IsFalse(_courseManage.ClassTime[0].Wednesday);
            Assert.IsFalse(_courseManage.ClassTime[1].Saturday);
            _courseManage.LoadCourseClassTimeToDataGridView(1);
            _courseManage.LoadCourseClassTimeToDataGridView(null);
            _courseManage.LoadCourseClassTimeToDataGridView(-1);
            Assert.IsFalse(_courseManage.ClassTime[0].Friday);
            Assert.IsFalse(_courseManage.ClassTime[4].Wednesday);
            Assert.IsFalse(_courseManage.ClassTime[10].Saturday);
            Assert.IsTrue(_courseManage.ClassTime[4].Friday);
            Assert.IsTrue(_courseManage.ClassTime[10].Friday);
            Assert.IsFalse(_courseManage.ClassTime[5].Friday);
            Assert.IsFalse(_courseManage.ClassTime[11].Friday);
        }

        //測試重置classtime
        [TestMethod()]
        public void TestResetAllPeriods()
        {
            _courseManage.LoadCourseClassTimeToDataGridView(0);
            Assert.IsTrue(_courseManage.ClassTime[0].Monday);
            Assert.IsTrue(_courseManage.ClassTime[1].Monday);
            _courseManage.ResetAllPeriods();
            Assert.IsFalse(_courseManage.ClassTime[0].Monday);
            Assert.IsFalse(_courseManage.ClassTime[1].Monday);
        }

        //確認所有必填資料有沒有被填到
        [TestMethod()]
        public void TestCheckCourseNeccessary()
        {
            _course1.Hour = "3";
            _courseManage.TemporaryCourseData = _course1;
            _courseManage.LoadCourseClassTimeToDataGridView(0);
            Assert.IsFalse(_courseManage.CheckCourseNeccessary());//時數不足
            _courseManage.TemporaryCourseData.Hour = "2";
            Assert.IsTrue(_courseManage.CheckCourseNeccessary());//時數夠了
            _courseManage.TemporaryCourseData.Hour = "";
            Assert.IsFalse(_courseManage.CheckCourseNeccessary());//無法轉換時數
            _courseManage.TemporaryCourseData.Hour = "2";
            _courseManage.TemporaryCourseData.Name = "";
            Assert.IsFalse(_courseManage.CheckCourseNeccessary());//未填寫課名
        }

        //確認所有必填資料有沒有被填到
        [TestMethod()]
        public void TestCalulateTotalClassTime()
        {
            _courseManage.LoadCourseClassTimeToDataGridView(0);
            int result = (int)_courseManagePrivate.Invoke("CalulateTotalClassTime");
            Assert.IsTrue(result == 2);
            _courseManage.LoadCourseClassTimeToDataGridView(1);
            result = (int)_courseManagePrivate.Invoke("CalulateTotalClassTime");
            Assert.IsTrue(result == 4);
        }

        //測試確認變更修改到YourData
        [TestMethod()]
        public void TestChangeCourseInfo()
        {
            Data data = (Data)_courseManagePrivate.GetFieldOrProperty("_yourData");
            _courseManage.TemporaryCourseData = _course2;
            _courseManage.AddNewButtonMode = 0;//修改模式
            Assert.IsFalse(data.AllCourses[0].IsSameClass(_course2));
            _courseManage.ChangeCourseInfo(0);
            Assert.IsTrue(data.AllCourses[0].IsSameClass(_course2));
            _courseManage.AddNewButtonMode = 1;//新增模式
            _courseManage.TemporaryCourseData = _course1;
            Assert.IsTrue(data.AllCourses.Count() == 4);
            _courseManage.ChangeCourseInfo(0);
            Assert.IsTrue(data.AllCourses.Count() == 5);
            Assert.IsTrue(data.AllCourses[4].IsSameClass(_course1));
            _courseManage.AddNewButtonMode = 2;//不該存在
            _courseManage.ChangeCourseInfo(0);
            Assert.IsTrue(data.AllCourses.Count() == 5);
            Assert.IsTrue(data.AllCourses[4].IsSameClass(_course1));
        }

        //測試textBox只允許輸入數字
        [TestMethod()]
        public void TestInputTextBoxNumberOnly()
        {
            Assert.IsTrue(_courseManage.InputTextBoxNumberOnly((int)'a'));
            Assert.IsTrue(_courseManage.InputTextBoxNumberOnly((int)'z'));
            Assert.IsTrue(_courseManage.InputTextBoxNumberOnly((int)'A'));
            Assert.IsTrue(_courseManage.InputTextBoxNumberOnly((int)'Z'));
            Assert.IsFalse(_courseManage.InputTextBoxNumberOnly((int)'0'));
            Assert.IsFalse(_courseManage.InputTextBoxNumberOnly((int)'9'));
            Assert.IsFalse(_courseManage.InputTextBoxNumberOnly(8));
        }

        //測試
        [TestMethod()]
        public void TestAddNewClassMode()
        {
            _courseManage.AddNewClassMode = 0;
            Assert.IsTrue(_courseManage.AddNewClassMode == 0);
            Assert.AreEqual(_courseManage.ClassGroupBoxText, "班級");
            Assert.IsFalse(_courseManage.AppendClassButtonEnable);
            _courseManage.AddNewClassMode = 1;
            Assert.IsTrue(_courseManage.AddNewClassMode == 1);
            Assert.AreEqual(_courseManage.ClassGroupBoxText, "新增班級");
            Assert.IsFalse(_courseManage.AppendClassButtonEnable);
        }

        //測試
        [TestMethod()]
        public void TestChangeClassTextBoxtText()
        {
            _courseManage.AddNewClassMode = 0;
            _courseManage.ClassNameTextBoxText = "123";
            Assert.AreEqual(_courseManage.ClassNameTextBoxText , "123");
            Assert.IsFalse(_courseManage.AppendClassButtonEnable);
            _courseManage.AddNewClassMode = 1;
            _courseManage.ClassNameTextBoxText = "321";
            Assert.AreEqual(_courseManage.ClassNameTextBoxText, "321");
            Assert.IsTrue(_courseManage.AppendClassButtonEnable);
            _courseManage.ClassNameTextBoxText = "";
            Assert.IsFalse(_courseManage.AppendClassButtonEnable);
        }

        //確認變更修改到YourData
        [TestMethod()]
        public void TestGetClassCoursesList()
        {
            List<string> result = _courseManage.GetClassCoursesList(-1);
            Assert.AreEqual(result, null);
            result = _courseManage.GetClassCoursesList(0);
            List<string> expectValue = new List<string>() { _course1.Name, _course3.Name };
            Assert.IsTrue(expectValue.Count == result.Count);
            for (int index = 0; index < expectValue.Count; index++)
                Assert.AreEqual(expectValue[0], result[0]);
        }
    }
}