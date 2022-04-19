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
        public event PropertyChangedEventHandler PropertyChanged;

        public enum Index : int
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
            Experiment,
            Class,
            IsOpened
        }

        private const int INDEX_SUNDAY = 0;
        private const int INDEX_MONDAY = 1;
        private const int INDEX_TUESDAY = 2;
        private const int INDEX_WEDNESDAY = 3;
        private const int INDEX_THURSDAY = 4;
        private const int INDEX_FRIDAY = 5;
        private const int INDEX_SATURDAY = 6;
        private const int WEEK = 7;

        private string _number;
        private string _name;
        private string _stage;
        private string _credit;
        private string _hour;
        private string _teacher;
        private List<string> _classTime;
        private string _classroom;
        private string _numberOfStudent;
        private string _note;
        private string _numberOfDropStudent;
        private string _assistance;
        private string _language;
        private string _syllabus;
        private string _audit;
        private string _experiment;
        private string _classType;
        private string _class;
        private bool _isOpened;

        const string NOON = "N";
        const string TEN = "A";
        const string ELEVEN = "B";
        const string TWELVE = "C";
        const string THIRTEEN = "D";
        const string NONE = " ";

        const int ONE_INTEGER = 0;
        const int NOON_INTEGER = 4;
        const int TEN_INTEGER = 10;
        const int ELEVEN_INTEGER = 11;
        const int TWELVE_INTEGER = 12;
        const int THIRTEEN_INTEGER = 13;

        //變更內容觸發事件
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                this._number = value;
                NotifyPropertyChanged("Number");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Stage
        {
            get
            {
                return _stage;
            }
            set
            {
                this._stage = value;
                NotifyPropertyChanged("Stage");
            }
        }

        public string Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                this._credit = value;
                NotifyPropertyChanged("Credit");
            }
        }

        public string Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                this._hour = value;
                NotifyPropertyChanged("Hour");
            }
        }

        public string Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                this._teacher = value;
                NotifyPropertyChanged("Teacher");
            }
        }

        public List<string> ClassTime
        {
            get
            {
                return _classTime;
            }
            set
            {
                this._classTime = value;
                NotifyPropertyChanged("ClassTime");
            }
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
                NotifyPropertyChanged("ClassTimeSunday");
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
                NotifyPropertyChanged("ClassTimeMonday");
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
                NotifyPropertyChanged("ClassTimeTuesday");
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
                NotifyPropertyChanged("ClassTimeWednesday");
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
                NotifyPropertyChanged("ClassTimeThursday");
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
                NotifyPropertyChanged("ClassTimeFriday");
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
                NotifyPropertyChanged("ClassTimeSaturday");
            }
        }

        public string Classroom
        {
            get
            {
                return _classroom;
            }
            set
            {
                this._classroom = value;
                NotifyPropertyChanged("Classroom");
            }
        }

        public string NumberOfStudent
        {
            get
            {
                return _numberOfStudent;
            }
            set
            {
                this._numberOfStudent = value;
                NotifyPropertyChanged("NumberOfStudent");
            }
        }

        public string Note
        {
            get
            {
                return _note;
            }
            set
            {
                this._note = value;
                NotifyPropertyChanged("Note");
            }
        }

        public string NumberOfDropStudent
        {
            get
            {
                return _numberOfDropStudent;
            }
            set
            {
                this._numberOfDropStudent = value;
                NotifyPropertyChanged("NumberOfDropStudent");
            }
        }

        public string Assistance
        {
            get
            {
                return _assistance;
            }
            set
            {
                this._assistance = value;
                NotifyPropertyChanged("Assistance");
            }
        }

        public string Language
        {
            get
            {
                return _language;
            }
            set
            {
                this._language = value;
                NotifyPropertyChanged("Language");
            }
        }

        public string Syllabus
        {
            get
            {
                return _syllabus;
            }
            set
            {
                this._syllabus = value;
                NotifyPropertyChanged("Syllabus");
            }
        }

        public string Audit
        {
            get
            {
                return _audit;
            }
            set
            {
                this._audit = value;
                NotifyPropertyChanged("Audit");
            }
        }

        public string Experiment
        {
            get
            {
                return _experiment;
            }
            set
            {
                this._experiment = value;
                NotifyPropertyChanged("Experiment");
            }
        }

        public string ClassType
        {
            get
            {
                return _classType;
            }
            set
            {
                this._classType = value;
                NotifyPropertyChanged("ClassType");
            }
        }

        public string Class
        {
            get
            {
                return _class;
            }
            set
            {
                this._class = value;
                NotifyPropertyChanged("Class");
            }
        }

        private const string OPENED = "開課";
        private const string UNOPENED = "未開課";
        public string IsOpened
        {
            get
            {
                return _isOpened ? OPENED : UNOPENED;
            }
            set
            {
                this._isOpened = value == OPENED;
                NotifyPropertyChanged("IsOpened");
            }
        }
    }
}
