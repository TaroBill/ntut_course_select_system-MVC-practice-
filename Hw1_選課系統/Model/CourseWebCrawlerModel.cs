using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class CourseWebCrawlerModel
    {
        public CourseWebCrawlerModel() 
        { 

        }

        //判定兩個List裡的課程有沒有衝堂，有的話把衝堂的課程加到List並回傳
        public List<Course> CheckCourseDuplicate(List<Course> course1, List<Course> course2, Func<Course, Course, bool> checkFunction)
        {
            List<Course> result = new List<Course>();
            for (int course1Index = 0; course1Index < course1.Count(); course1Index++)
            {
                for (int course2Index = 0; course2Index < course2.Count(); course2Index++)
                {
                    if (course1.ElementAt(course1Index) == course2.ElementAt(course2Index))
                        continue;
                    if (checkFunction(course1.ElementAt(course1Index), course2.ElementAt(course2Index)))
                    {
                        result.Add(course1.ElementAt(course1Index));
                        result.Add(course2.ElementAt(course2Index));
                    }
                }
            }
            return result;
        }

        const string COURSE_CONFLICT = "衝堂:";
        const string COURSE_NAME_REPEAT = "同名:";
        const string CHANGE_LINE = "\n";

        //回傳所有衝堂的課程名稱，若沒有則回傳空字串;
        public string ConflictCourses(List<Course> temporaryList, List<Course> yourCourseList, int mode)
        {
            string conflictType;
            Func<Course, Course, bool> conflict;
            if (mode == 0)
            {
                conflictType = COURSE_CONFLICT;
                conflict = (course1, course2) => course1.IsClassConflict(course2);
            }
            else if (mode == 1)
            {
                conflictType = COURSE_NAME_REPEAT;
                conflict = (course1, course2) => course1.IsSameName(course2);
            }
            else
                return "";
            List<Course> result = CheckCourseDuplicate(temporaryList, temporaryList, conflict).Union(CheckCourseDuplicate(temporaryList, yourCourseList.ToList<Course>(), conflict)).ToList<Course>();
            if (result.Count() != 0)
            {
                foreach (Course course in result)
                    conflictType += course.GetCourseInfo();
                return conflictType + CHANGE_LINE;
            }
            return "";
        }

        //回傳衝堂或重複的課
        public string CourseConflictResult(List<string[]> courseList, List<Course> yourCourseList)
        {
            const string POSITIVE = "True";
            List<Course> temporaryList = new List<Course>();
            for (int index = 0; index < courseList.Count(); index++)
                if (courseList.ElementAt(index)[0] == POSITIVE)
                    temporaryList.Add(new Course(courseList.ElementAt(index)));
            return ConflictCourses(temporaryList, yourCourseList, 0) + ConflictCourses(temporaryList, yourCourseList, 1);
        }
    }
}
