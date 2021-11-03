using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public partial class Course : INotifyPropertyChanged
    {
        public Course(string number, string name, string stage, string credit, 
            string teacher, string classType, string assistance, string language,
            string note, string hour, string className)
        {
            this.Number = number;
            this.Name = name;
            this.Stage = stage;
            this.Credit = credit;
            this.Hour = hour;
            this.ClassType = classType;
            this.Teacher = teacher;
            this.ClassTime = new List<string>();
            for (int index = 0; index < WEEK; index++)
                ClassTime.Add("");
            this.Classroom = "";
            this.NumberOfStudent = "";
            this.NumberOfDropStudent = "";
            this.Assistance = assistance;
            this.Language = language;
            this.Syllabus = "";
            this.Note = note;
            this.Audit = "";
            this.Experiment = "";
            this.Class = className;
        }

        public Course(HtmlNodeCollection nodeTableDatas)
        {
            this.Number = nodeTableDatas.ElementAt((int)Index.Number).InnerText.Trim();
            this.Name = nodeTableDatas.ElementAt((int)Index.Name).InnerText.Trim();
            this.Stage = nodeTableDatas.ElementAt((int)Index.Stage).InnerText.Trim();
            this.Credit = nodeTableDatas.ElementAt((int)Index.Credit).InnerText.Trim();
            this.Hour = nodeTableDatas.ElementAt((int)Index.Hour).InnerText.Trim();
            this.ClassType = nodeTableDatas.ElementAt((int)Index.ClassType).InnerText.Trim();
            this.Teacher = nodeTableDatas.ElementAt((int)Index.Teacher).InnerText.Trim();
            this.ClassTime = new List<string>//classTime
            {
                        nodeTableDatas.ElementAt((int)Index.Sunday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Monday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Tuesday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Wednesday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Thursday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Friday).InnerText.Trim(), nodeTableDatas.ElementAt((int)Index.Saturday).InnerText.Trim()
            };
            this.Classroom = nodeTableDatas.ElementAt((int)Index.Classroom).InnerText.Trim();
            this.NumberOfStudent = nodeTableDatas.ElementAt((int)Index.NumberOfStudent).InnerText.Trim();
            this.NumberOfDropStudent = nodeTableDatas.ElementAt((int)Index.NumberOfDropStudent).InnerText.Trim();
            this.Assistance = nodeTableDatas.ElementAt((int)Index.TeacherAssistance).InnerText.Trim();
            this.Language = nodeTableDatas.ElementAt((int)Index.Language).InnerText.Trim();
            this.Syllabus = nodeTableDatas.ElementAt((int)Index.Syllabus).InnerText.Trim();
            this.Note = nodeTableDatas.ElementAt((int)Index.Note).InnerText.Trim();
            this.Audit = nodeTableDatas.ElementAt((int)Index.Audit).InnerText.Trim();
            this.Experiment = nodeTableDatas.ElementAt((int)Index.Experiment).InnerText.Trim();
        }

        public Course(string[] listCourse)
        {
            this.Number = listCourse[(int)Index.Number + 1];
            this.Name = listCourse[(int)Index.Name + 1];
            this.Stage = listCourse[(int)Index.Stage + 1];
            this.Credit = listCourse[(int)Index.Credit + 1];
            this.Hour = listCourse[(int)Index.Hour + 1];
            this.ClassType = listCourse[(int)Index.ClassType + 1];
            this.Teacher = listCourse[(int)Index.Teacher + 1];
            this.ClassTime = new List<string>
            {
                        listCourse.ElementAt((int)Index.Sunday + 1), listCourse.ElementAt((int)Index.Monday + 1), listCourse.ElementAt((int)Index.Tuesday + 1), listCourse.ElementAt((int)Index.Wednesday + 1), listCourse.ElementAt((int)Index.Thursday + 1), listCourse.ElementAt((int)Index.Friday + 1), listCourse.ElementAt((int)Index.Saturday + 1)
            };
            this.Classroom = listCourse[(int)Index.Classroom + 1];
            this.NumberOfStudent = listCourse[(int)Index.NumberOfStudent + 1];
            this.NumberOfDropStudent = listCourse[(int)Index.NumberOfDropStudent + 1];
            this.Assistance = listCourse[(int)Index.TeacherAssistance + 1];
            this.Language = listCourse[(int)Index.Language + 1];
            this.Syllabus = listCourse[(int)Index.Syllabus + 1];
            this.Note = listCourse[(int)Index.Note + 1];
            this.Audit = listCourse[(int)Index.Audit + 1];
            this.Experiment = listCourse[(int)Index.Experiment + 1];
            this.Class = listCourse[(int)Index.Class + 1];
        }

        //將Course的所有內容轉為string
        public string[] ConvertToStringList()
        {
            const string NEGATIVE = "False";
            string[] row = 
                { 
                    NEGATIVE, _number, _name, _stage, _credit, _hour, _classType, _teacher, ClassTimeSunday, ClassTimeMonday, ClassTimeTuesday, ClassTimeWednesday, ClassTimeThursday, ClassTimeFriday, ClassTimeSaturday, _classroom, _numberOfStudent, _numberOfDropStudent, _assistance, _language, _note, _syllabus, _audit, _experiment, _class };
            return row;
        }

        //判定此堂課與輸入的課有沒有衝突
        public bool IsClassConflict(Course course)
        {
            for (int classTimeIndex = 0; classTimeIndex < this.ClassTime.Count(); classTimeIndex++)
            {
                if (ClassTime[classTimeIndex] == "" || course.ClassTime[classTimeIndex] == "")
                    continue;
                const char NONE = ' ';
                string[] thisCourse = ClassTime[classTimeIndex].Split(NONE);
                string[] thatCourse = course.ClassTime[classTimeIndex].Split(NONE);
                var intersectedList = thisCourse.Intersect(thatCourse);
                if (intersectedList.Count() != 0)
                    return true;
            }
            return false;
        }

        //判定名稱是否相同
        public bool IsSameName(Course course)
        {
            return (this.Name == course.Name);
        }

        //回傳「課號-課名」
        public string GetCourseInfo()
        {
            const string LEFT_QUOTES = "「";
            const string RIGHT_QUOTES = "」";
            const string MINUS = "-";
            return LEFT_QUOTES + this.Number + MINUS + this.Name + RIGHT_QUOTES;
        }

        //分割ClassTime
        public string[] SplitClassTime(int index)
        {
            const char NONE = ' ';
            return ClassTime[index].Split(NONE);
        }

        const int PERIODS = 14;

        //將此Course輸出到輸入的ClassTimePeriod
        public void ClassTimePeriods(BindingList<ClassTimePeriod> periods)
        {
            for (int periodIndex = 0; periodIndex < PERIODS; periodIndex++)
                periods[periodIndex].ResetAllPeriod();
            for (int classTimeIndex = 0; classTimeIndex < this.ClassTime.Count(); classTimeIndex++)
            {
                string[] activeTime = this.SplitClassTime(classTimeIndex);
                if (activeTime.Count() > 0 && activeTime[0] != "")
                {
                    foreach (string time in activeTime)
                        periods[ConvertPeriodStringToInteger(time)].ClassTime[classTimeIndex] = true;
                }
            }
        }

        //依照課號判定是否為同堂課
        public bool IsSameClass(string courseNumber)
        {
            return (this.Number == courseNumber);
        }

        //依照必填項目東西判定是否為同堂課
        public bool IsSameClass(Course course)
        {
            return (this.Number == course.Number) && (this.Name == course.Name) && (this.Class == course.Class) && (this.Teacher == course.Teacher);
        }

        //確認課程必填項目有沒有填
        public bool IsAllNecessary()
        {
            return (Number != "") && (Name != "") && (Stage != "") && (Credit != "") && (Teacher != "") && (ClassType != "") && (Hour != "") && (Class != "");
        }

        //將另一堂課的必填內容複製到此
        public void CopyNecessaryData(Course course)
        {
            Number = course.Number;
            Name = course.Name;
            Stage = course.Stage;
            Credit = course.Credit;
            Teacher = course.Teacher;
            ClassType = course.ClassType;
            Assistance = course.Assistance;
            Language = course.Language;
            Note = course.Note;
            Hour = course.Hour;
            Class = course.Class;
            ClassTime = course.ClassTime;
        }

        //將string轉換成int
        public static int ConvertPeriodStringToInteger(string period)
        {
            switch (period)
            {
                case NOON:
                    return NOON_INTEGER;
                case TEN:
                    return TEN_INTEGER;
                case ELEVEN:
                    return ELEVEN_INTEGER;
                case TWELVE:
                    return TWELVE_INTEGER;
                case THIRTEEN:
                    return THIRTEEN_INTEGER;
                default:
                    Int32.TryParse(period, out int output);
                    if (output <= NOON_INTEGER)
                        return output - 1;
                    return output;
            }
        }

        //將int轉換成string
        public static string ConvertPeriodIntegerToString(int period)
        {
            if (period < NOON_INTEGER && period >= ONE_INTEGER)
                return (period + 1).ToString();
            else if (period < TEN_INTEGER && period > NOON_INTEGER)
                return period.ToString();
            switch (period)
            {
                case NOON_INTEGER:
                    return NOON;
                case TEN_INTEGER:
                    return TEN;
                case ELEVEN_INTEGER:
                    return ELEVEN;
                case TWELVE_INTEGER:
                    return TWELVE;
                case THIRTEEN_INTEGER:
                    return THIRTEEN;
                default:
                    return "";
            }
        }

        //將datagridview的classTime轉換成Course所儲存的方式
        public void ConvertClassTimeStyle(List<ClassTimePeriod> periods)
        {
            List<string> result = new List<string>();
            for (int weekIndex = 0; weekIndex < WEEK; weekIndex++)
            {
                result.Add("");
                for (int periodIndex = 0; periodIndex < PERIODS; periodIndex++)
                {
                    if (periods[periodIndex].ClassTime[weekIndex])
                    {
                        if (result[weekIndex] == "")
                            result[weekIndex] += ConvertPeriodIntegerToString(periodIndex);
                        else
                            result[weekIndex] += NONE + ConvertPeriodIntegerToString(periodIndex);
                    }
                }
            }
            this.ClassTime = result;
        }
    }
}
