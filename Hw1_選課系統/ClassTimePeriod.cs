using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class ClassTimePeriod : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //通知ClassTimeChanged
        public void NotifyCourseObserver(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _period;
        const int WEEK = 7;
        private bool[] _classTime = new bool[WEEK];

        public ClassTimePeriod(string period)
        {
            this._period = period;
            this.Sunday = false;
            this.Monday = false;
            this.Tuesday = false;
            this.Wednesday = false;
            this.Thursday = false;
            this.Friday = false;
            this.Saturday = false;
        }

        //計算每天的該節課的時間總數
        public int TotalClassTime()
        {
            int total = 0;
            foreach (bool value in _classTime)
            {
                if (value)
                    total++;
            }
            return total;
        }

        //將所有設為false
        public void ResetAllPeriod()
        {
            for (int weekIndex = 0; weekIndex < WEEK; weekIndex++)
            {
                _classTime[weekIndex] = false;
            }
        }

        public string Period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
                NotifyCourseObserver("Period");
            }
        }

        public bool[] ClassTime
        {
            get
            {
                return _classTime;
            }
            set
            {
                _classTime = value;
                NotifyCourseObserver("ClassTime");
            }
        }

        public bool Sunday
        {
            get
            {
                return _classTime[0];
            }
            set
            {
                _classTime[0] = value;
                NotifyCourseObserver("Sunday");
            }
        }
        public bool Monday
        {
            get
            {
                return _classTime[1];
            }
            set
            {
                _classTime[1] = value;
                NotifyCourseObserver("Monday");
            }
        }
        public bool Tuesday
        {
            get
            {
                return _classTime[2];
            }
            set
            {
                _classTime[2] = value;
                NotifyCourseObserver("Tuesday");
            }
        }
        public bool Wednesday
        {
            get
            {
                return _classTime[3];
            }
            set
            {
                _classTime[3] = value;
                NotifyCourseObserver("Wednesday");
            }
        }
        public bool Thursday
        {
            get
            {
                return _classTime[4];
            }
            set
            {
                _classTime[4] = value;
                NotifyCourseObserver("Thursday");
            }
        }
        public bool Friday
        {
            get
            {
                return _classTime[5];
            }
            set
            {
                _classTime[5] = value;
                NotifyCourseObserver("Friday");
            }
        }
        public bool Saturday
        {
            get
            {
                return _classTime[6];
            }
            set
            {
                _classTime[6] = value;
                NotifyCourseObserver("Saturday");
            }
        }
    }
}
