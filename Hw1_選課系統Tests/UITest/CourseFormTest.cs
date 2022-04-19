using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統.Tests
{
    [TestClass()]
    public class CourseFormTest
    {
        private Robot _startUpRobot;
        private string targetAppPath;
        private const string START_UP_FORM = "StartUpForm";
        private const string COURSE_FORM = "CourseForm";
        private const string COURSE_MANAGE_FORM = "CourseManageForm";
        private const string COURSE_SELECT_RESULT_FORM = "CourseSelectionResultForm1";

        // init
        [TestInitialize]
        public void Initialize()
        {
            var projectName = "Hw1_選課系統";
            string solutionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            targetAppPath = Path.Combine(solutionPath, projectName, "bin", "Debug", "Hw1_選課系統.exe");
            _startUpRobot = new Robot(targetAppPath, START_UP_FORM);
        }

        //清除程式
        [TestCleanup()]
        public void Cleanup()
        {
            _startUpRobot.CleanUp();
        }

        //開啟選課系統和課程管理系統
        private void OpenSeletingForms()
        {
            _startUpRobot.ClickButton("Course Seleting System");
            _startUpRobot.Sleep(3);
            _startUpRobot.SwitchTo(COURSE_FORM);
            _startUpRobot.ClickButton("查看選課結果");
        }

        //選擇課堂
        private void AddACourse(string dataGridView, int rowIndex)
        {
            _startUpRobot.ClickDataGridViewCellBy(dataGridView, rowIndex, "選");
            _startUpRobot.ClickButton("確認送出");
        }

        //測試加退選
        [TestMethod]
        public void TestSelectCourse()
        {
            OpenSeletingForms();
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView0", 12);
            AddACourse("dataGridView0", 5);
            _startUpRobot.AssertText("65535", "加選成功"); //彈出視窗
            _startUpRobot.ClickButton("確定");
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView0", 11);
            _startUpRobot.ClickTabControl("電子三");
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView1", 24);
            AddACourse("dataGridView1", 5);
            _startUpRobot.AssertText("65535", "加選成功"); //彈出視窗
            _startUpRobot.ClickButton("確定");
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView1", 23);
            _startUpRobot.SwitchTo(COURSE_SELECT_RESULT_FORM);
            _startUpRobot.AssertDataGridViewRowCountBy("_courseResultGridView", 2);
            string[] expectCourse1 = { "退選", "291706", "計算機網路", "1", "3.0", "3", "▲", "吳和庭", "", "3 4", "2", "", "", "", "", "六教327(e)", "94", "1", "", "", "查詢", "◎", "", "" };
            string[] expectCourse2 = { "退選", "291507", "專題討論", "1", "1.0", "2", "▲", "黃育賢", "", "", "", "", "", "5 6", "", "二教207(e)", "59", "0", "", "", "查詢", "", "", "" };
            _startUpRobot.AssertDataGridViewRowDataBy("_courseResultGridView", 0, expectCourse1);
            _startUpRobot.AssertDataGridViewRowDataBy("_courseResultGridView", 1, expectCourse2);
            _startUpRobot.ClickDataGridViewCellBy("_courseResultGridView", 1, "退選");
            _startUpRobot.ClickDataGridViewCellBy("_courseResultGridView", 0, "退選");
            _startUpRobot.SwitchTo(COURSE_FORM);
            expectCourse2[0] = "False";
            _startUpRobot.AssertDataGridViewRowDataBy("dataGridView1", 5, expectCourse2);
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView1", 24);
            _startUpRobot.ClickTabControl("資工三");
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView0", 12);
        }

        //測試衝堂和課堂名稱相同
        [TestMethod]
        public void TestSelectConflictCourse()
        {
            OpenSeletingForms();
            _startUpRobot.ClickDataGridViewCellBy("dataGridView0", 2, "選");
            _startUpRobot.ClickDataGridViewCellBy("dataGridView0", 3, "選");
            _startUpRobot.ClickButton("確認送出");
            _startUpRobot.AssertText("65535", "同名:「291703-博雅選修課程」「291704-博雅選修課程」\n"); //彈出視窗
            _startUpRobot.ClickButton("確定");
            _startUpRobot.ClickTabControl("電子三");
            _startUpRobot.ClickButton("向下翻頁");
            _startUpRobot.ClickButton("向下翻頁");
            _startUpRobot.ClickDataGridViewCellBy("dataGridView1", 22, "選");
            _startUpRobot.ClickDataGridViewCellBy("dataGridView1", 19, "選");
            _startUpRobot.ClickButton("確認送出");
            _startUpRobot.AssertText("65535", "衝堂:「294560-天線工程」「294562-智慧整合感控系統概論」\n"); //彈出視窗
            _startUpRobot.ClickButton("確定");
        }

        //測試更改內部值儲存按鈕enable狀態
        [TestMethod]
        public void TestManageCourseButtonEnable()
        {
            _startUpRobot.ClickButton("Course Management System");
            _startUpRobot.Sleep(3);
            _startUpRobot.SwitchTo(COURSE_MANAGE_FORM);
            _startUpRobot.ClickButton("計算機網路");
            _startUpRobot.ClickButton("計算機網路");
            _startUpRobot.AssertEnable("儲存", false);
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNumberTextBox").SendKeys("123");
            _startUpRobot.AssertEnable("儲存", true);
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNumberTextBox").Clear();
            _startUpRobot.AssertEnable("儲存", false);
            _startUpRobot.ClickButton("視窗程式設計");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 5, "四");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 6, "四");
            _startUpRobot.AssertEnable("儲存", true);
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 6, "四");
            _startUpRobot.AssertEnable("儲存", false);
        }

        //測試更改課成資訊所有form同時修改
        [TestMethod]
        public void TestManageCourse()
        {
            OpenSeletingForms();
            _startUpRobot.SwitchTo(START_UP_FORM);
            _startUpRobot.ClickButton("Course Management System");
            _startUpRobot.SwitchTo(COURSE_MANAGE_FORM);
            _startUpRobot.ClickButton("視窗程式設計");
            _startUpRobot.ClickButton("視窗程式設計");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNumberTextBox").SendKeys("270915");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNameTextBox").SendKeys("物件導向分析與設計");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseCreditTextBox").SendKeys("2");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseHourComboBox").Click();
            _startUpRobot.ClickButton("2");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseClassComboBox").Click();
            _startUpRobot.ClickButton("電子三");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 2, "四");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 3, "四");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 6, "四");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 2, "一");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 2, "二");

            _startUpRobot.ClickButton("儲存");
            Assert.AreEqual("物件導向分析與設計", _startUpRobot.Driver.FindElementByName("物件導向分析與設計").Text);
            _startUpRobot.SwitchTo(COURSE_FORM);
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView0", 11);
            _startUpRobot.ClickTabControl("電子三");
            _startUpRobot.AssertDataGridViewRowCountBy("dataGridView1", 25);
            string[] expectValue = { "False", "270915", "物件導向分析與設計", "1", "2", "2", "★", "陳偉凱", "", "3", "3", "", "", "", "", "二教206(e)二教205(e)", "43", "20", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "" };
            _startUpRobot.AssertDataGridViewRowDataBy("dataGridView1", 0, expectValue);
            _startUpRobot.ClickDataGridViewCellBy("dataGridView1", 0, "選");
            _startUpRobot.ClickButton("確認送出");
            _startUpRobot.CloseMessageBox();
            _startUpRobot.SwitchTo(COURSE_SELECT_RESULT_FORM);
            expectValue[0] = "退選";
            _startUpRobot.AssertDataGridViewRowDataBy("_courseResultGridView", 0, expectValue);
        }

        //測試加入課程
        [TestMethod]
        public void TestAddCourse()
        {
            OpenSeletingForms();
            _startUpRobot.SwitchTo(START_UP_FORM);
            _startUpRobot.ClickButton("Course Management System");
            _startUpRobot.SwitchTo(COURSE_MANAGE_FORM);
            _startUpRobot.Driver.FindElementByAccessibilityId("_addNewCourseButton").Click();
            _startUpRobot.AssertText("_saveButton", "新增");
            _startUpRobot.AssertEnable("新增", false);
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNumberTextBox").SendKeys("270915");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseNameTextBox").SendKeys("物件導向分析與設計");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseStageTextBox").SendKeys("1");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseTeacherTextBox").SendKeys("陳碩漢");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseCreditTextBox").SendKeys("2");
            _startUpRobot.Driver.FindElementByAccessibilityId("_courseHourComboBox").Click();
            _startUpRobot.ClickButton("2");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 2, "一");
            _startUpRobot.ClickDataGridViewCellBy("_classTimeDataGridView", 2, "二");
            _startUpRobot.AssertEnable("新增", true);
            _startUpRobot.ClickButton("新增");
            Assert.AreEqual("物件導向分析與設計", _startUpRobot.Driver.FindElementByName("物件導向分析與設計").Text);
            _startUpRobot.SwitchTo(COURSE_FORM);
            string[] expectValue = { "False", "270915", "物件導向分析與設計", "1", "2", "2", "○", "陳碩漢", "", "3", "3", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            _startUpRobot.ClickButton("向下翻頁");
            _startUpRobot.AssertDataGridViewRowDataBy("dataGridView0", 12, expectValue);
        }

        //測試匯入資工系所有課程
        [TestMethod]
        public void TestAddAllComputerScienceCourse()
        {
            OpenSeletingForms();
            _startUpRobot.SwitchTo(START_UP_FORM);
            _startUpRobot.ClickButton("Course Management System");
            _startUpRobot.SwitchTo(COURSE_MANAGE_FORM);
            _startUpRobot.ClickButton("匯入資工系全部課程");
            _startUpRobot.AssertListBoxCountBy("_coursesListBox", 87);
            _startUpRobot.SwitchTo(COURSE_FORM);
            _startUpRobot.AssertTabPageCountBy("_tabControl1", 6);
        }

        //測試新增班級
        [TestMethod]
        public void TestAddNewClass()
        {
            OpenSeletingForms();
            _startUpRobot.SwitchTo(START_UP_FORM);
            _startUpRobot.ClickButton("Course Management System");
            _startUpRobot.SwitchTo(COURSE_FORM);
            _startUpRobot.AssertTabPageCountBy("_tabControl1", 2);
            _startUpRobot.SwitchTo(COURSE_MANAGE_FORM);
            _startUpRobot.ClickButton("班級管理");
            _startUpRobot.AssertListBoxCountBy("_allClassesListBox", 2);
            var addClassButton = _startUpRobot.Driver.FindElementByAccessibilityId("_addClassButton");
            Assert.AreEqual(true, addClassButton.Enabled);
            var addButton = _startUpRobot.Driver.FindElementByAccessibilityId("_addButton");
            Assert.AreEqual(false, addButton.Enabled);
            _startUpRobot.ClickButton("資工三");
            _startUpRobot.AssertText("_classNameTextBox", "資工三");
            _startUpRobot.ClickButton("電子三");
            _startUpRobot.AssertText("_classNameTextBox", "電子三");
            _startUpRobot.Driver.FindElementByAccessibilityId("_addClassButton").Click();
            _startUpRobot.AssertText("_classNameTextBox", "");
            addButton = _startUpRobot.Driver.FindElementByAccessibilityId("_addButton");
            Assert.AreEqual(false, addButton.Enabled);
            _startUpRobot.Driver.FindElementByAccessibilityId("_classNameTextBox").SendKeys("英文一");
            addButton = _startUpRobot.Driver.FindElementByAccessibilityId("_addButton");
            Assert.AreEqual(true, addButton.Enabled);
            _startUpRobot.Driver.FindElementByAccessibilityId("_addButton").Click();
            _startUpRobot.AssertListBoxCountBy("_allClassesListBox", 3);
            _startUpRobot.ClickButton("英文一");
            _startUpRobot.AssertText("_classNameTextBox", "英文一");
            _startUpRobot.SwitchTo(COURSE_FORM);
            _startUpRobot.AssertTabPageCountBy("_tabControl1", 3);
        }
    }
}
