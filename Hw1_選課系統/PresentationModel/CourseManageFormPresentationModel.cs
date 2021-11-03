﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class CourseManageFormPresentationModel
    {
        public delegate void ButtonChangedEnableEventHandler();
        public ButtonChangedEnableEventHandler ButtonChangedEnable
        {
            get; set;
        }

        private readonly Data _yourData;
        const int PERIODS = 14;
        const string SAVE = "儲存";
        const string ADD = "新增";
        const string EDIT = "編輯課程";
        const string APPEND = "新增課程";

        public CourseManageFormPresentationModel(Data yourData)
        {
            _yourData = yourData;
            _classTime = new BindingList<ClassTimePeriod>();
            for (int periodIndex = 0; periodIndex < PERIODS; periodIndex++)
            {
                _classTime.Add(new ClassTimePeriod(Course.ConvertPeriodIntegerToString(periodIndex)));
            }
            AddNewButtonMode = 0;
        }

        private readonly BindingList<ClassTimePeriod> _classTime;
        public BindingList<ClassTimePeriod> ClassTime
        {
            get
            {
                return _classTime;
            }
        }

        private Course _temporaryCourseData;
        public Course TemporaryCourseData
        {
            get
            {
                return _temporaryCourseData;
            }
            set
            {
                _temporaryCourseData = value;
            }
        }

        private bool _saveButtonEnable;
        public bool SaveButtonEnable
        {
            get
            {
                return _saveButtonEnable;
            }
            set
            {
                _saveButtonEnable = value;
                NotifyButtonObserver();
            }
        }

        public string SaveButtonText
        {
            get; set;
        }

        public string GroupBoxText
        {
            get; set;
        }

        private int _addNewButtonMode;
        public int AddNewButtonMode
        {
            get
            {
                return _addNewButtonMode;
            }
            set
            {
                _addNewButtonMode = value;
                if (_addNewButtonMode == 0)
                {
                    SaveButtonText = SAVE;
                    GroupBoxText = EDIT;
                }
                else
                {
                    SaveButtonText = ADD;
                    GroupBoxText = APPEND;
                }
                NotifyButtonObserver();
            }
        }

        //呼叫view更新所有button狀態
        private void NotifyButtonObserver()
        {
            ButtonChangedEnable?.Invoke();
        }

        //設置ClassTime表格enable
        public void SetClassTimeEnable(Point? point, bool? value)
        {
            if (point != null && value != null)
            {
                _classTime[point.Value.Y].ClassTime[point.Value.X - 1] = (bool)value;
            }
        }

        //讀出該堂課的classTime並轉成datagridview顯示狀態
        public void LoadCourseClassTimeToDataGridView(int? selectCourseIndex)
        {
            if (selectCourseIndex == null || selectCourseIndex < 0)
                return;
            Course course = _yourData.AllCourses[(int)selectCourseIndex];
            ResetAllPeriods();
             course.ClassTimePeriods(this._classTime);
        }

        //將classTime裡所有節都設為false
        public void ResetAllPeriods()
        {
            for (int periodIndex = 0; periodIndex < PERIODS; periodIndex++)
                _classTime[periodIndex].ResetAllPeriod();
        }

        //分析所有資料是不是都有填到
        public bool CheckCourseNeccessary()
        {
            bool successConvert = Int32.TryParse(TemporaryCourseData.Hour, out int hour);
            if (!successConvert)
                return false;
            if (hour <= CalulateTotalClassTime())
            {
                return TemporaryCourseData.IsAllNecessary();
            }
            return false;
        }

        //計算所有classTime
        private int CalulateTotalClassTime()
        {
            int totalTime = 0;
            foreach (ClassTimePeriod classTimePeriod in ClassTime)
            {
                totalTime += classTimePeriod.TotalClassTime();
            }
            return totalTime;
        }

        //確認變更修改到YourData
        public void ChangeCourseInfo(int allCourseIndex)
        {
            TemporaryCourseData.ConvertClassTimeStyle(ClassTime.ToList<ClassTimePeriod>());
            if (AddNewButtonMode == 0)
                _yourData.AllCourses[allCourseIndex].CopyNecessaryData(TemporaryCourseData);
            else if (AddNewButtonMode == 1)
                _yourData.AllCourses.Add(TemporaryCourseData);
            _yourData.NotifyCourseObserver();
        }

        //textBox只允許輸入數字
        public bool InputTextBoxNumberOnly(int key)
        {
            if ((key < 48 | key > 57) & key != 8)
            {
                return true;
            }
            return false;
        }
    }
}
