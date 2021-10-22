using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class Course
    {
        private enum Index : int
        {
            Number,
            Name,
            Stage,
            Credit,
            Hour,
            ClassType,
            Teacher,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Classroom,
            NumberOfStudent,
            NumberOfDropStudent,
            TeacherAssistance,
            Language,
            Syllabus,
            Note,
            Audit,
            Experiment
        }
        private const int INDEX_SUNDAY = 0;
        private const int INDEX_MONDAY = 1;
        private const int INDEX_TUESDAY = 2;
        private const int INDEX_WEDNESDAY = 3;
        private const int INDEX_THURSDAY = 4;
        private const int INDEX_FRIDAY = 5;
        private const int INDEX_SATURDAY = 6;

        public Course(string number, string name, string stage, string credit, string hour,
            string classType, string teacher, string classTimeSunday, string classTimeMonday, string classTimeTuesday,
            string classTimeWednesday, string classTimeThursday, string classTimeFriday, string classTimeSaturday, string classroom,
            string numberOfStudent, string numberOfDropStudent, string assistance, string language,
            string note, string syllabus, string audit, string experiment)
        {
            this.Number = number;
            this.Name = name;
            this.Stage = stage;
            this.Credit = credit;
            this.Hour = hour;
            this.ClassType = classType;
            this.Teacher = teacher;
            this.ClassTimeSunday = classTimeSunday;
            this.ClassTimeMonday = classTimeMonday;
            this.ClassTimeTuesday = classTimeTuesday;
            this.ClassTimeWednesday = classTimeWednesday;
            this.ClassTimeThursday = classTimeThursday;
            this.ClassTimeFriday = classTimeFriday;
            this.ClassTimeSaturday = classTimeSaturday;
            this.Classroom = classroom;
            this.NumberOfStudent = numberOfStudent;
            this.NumberOfDropStudent = numberOfDropStudent;
            this.Assistance = assistance;
            this.Language = language;
            this.Syllabus = syllabus;
            this.Note = note;
            this.Audit = audit;
            this.Experiment = experiment;
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
        }

        //將Course的所有內容轉為string
        public string[] ConvertToStringList()
        {
            const string NEGATIVE = "False";
            string[] row = 
                { 
                    NEGATIVE, this.Number, this.Name, this.Stage, this.Credit, this.Hour, this.ClassType, this.Teacher, this.ClassTime[INDEX_SUNDAY], this.ClassTime[INDEX_MONDAY], this.ClassTime[INDEX_TUESDAY], this.ClassTime[INDEX_WEDNESDAY], this.ClassTime[INDEX_THURSDAY], this.ClassTime[INDEX_FRIDAY], this.ClassTime[INDEX_SATURDAY], this.Classroom, this.NumberOfStudent,this.NumberOfDropStudent, this.Assistance, this.Language, this.Note, this.Syllabus, this.Audit, this.Experiment };
            return row;
        }

        //判定此堂課與輸入的課有沒有衝突
        public bool IsClassConflict(Course course)
        {
            for (int classTimeIndex = 0; classTimeIndex < this.ClassTime.Count(); classTimeIndex++)
            {
                if (this.ClassTime[classTimeIndex] == "" || course.ClassTime[classTimeIndex] == "")
                    continue;
                const char NONE = ' ';
                string[] thisCourse = this.ClassTime[classTimeIndex].Split(NONE);
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

        //依照課號判定是否為同堂課
        public bool IsSameClass(string courseNumber)
        {
            return (this.Number == courseNumber);
        }

        public string Number
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Stage
        {
            get; set;
        }

        public string Credit
        {
            get; set;
        }

        public string Hour
        {
            get; set;
        }

        public string Teacher
        {
            get; set;
        }

        public List<string> ClassTime
        {
            get; set;
        }

        public string ClassTimeSunday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_SUNDAY);
            }
            set
            {
                ClassTime[INDEX_SUNDAY] = value;
            }
        }

        public string ClassTimeMonday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_MONDAY);
            }
            set
            {
                ClassTime[INDEX_MONDAY] = value;
            }
        }

        public string ClassTimeTuesday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_TUESDAY);
            }
            set
            {
                ClassTime[INDEX_TUESDAY] = value;
            }
        }

        public string ClassTimeWednesday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_WEDNESDAY);
            }
            set
            {
                ClassTime[INDEX_WEDNESDAY] = value;
            }
        }

        public string ClassTimeThursday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_THURSDAY);
            }
            set
            {
                ClassTime[INDEX_THURSDAY] = value;
            }
        }

        public string ClassTimeFriday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_FRIDAY);
            }
            set
            {
                ClassTime[INDEX_FRIDAY] = value;
            }
        }

        public string ClassTimeSaturday
        {
            get
            {
                return ClassTime.ElementAt(INDEX_SATURDAY);
            }
            set
            {
                ClassTime[INDEX_SATURDAY] = value;
            }
        }

        public string Classroom
        {
            get; set;
        }

        public string NumberOfStudent
        {
            get; set;
        }

        public string Note
        {
            get; set;
        }

        public string NumberOfDropStudent
        {
            get; set;
        }

        public string Assistance
        {
            get; set;
        }

        public string Language
        {
            get; set;
        }

        public string Syllabus
        {
            get; set;
        }

        public string Audit
        {
            get; set;
        }

        public string Experiment
        {
            get; set;
        }

        public string ClassType
        {
            get; set;
        }
    }
}
