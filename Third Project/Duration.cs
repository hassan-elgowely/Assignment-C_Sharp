namespace Third_Project
{
    public class Duration
    {
        /// 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        #region Fields
        private double hours;
        private double minutes;
        private double seconds;
        #endregion


        #region properties
        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public double Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public double Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        #endregion


        #region Constructors
        public Duration(double _hours, double _minutes, double _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }

        public Duration(double _seconds)
        {
            hours = (int)(_seconds / (60 * 60));
            minutes = (int)((_seconds % (60 * 60)) / 60);
            seconds = (int)((_seconds % (60 * 60)) % 60);
        }
        public Duration()
        {
            
        }
        #endregion


        #region Methods
        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj!;

            return hours == duration.hours && minutes == duration.minutes && seconds == duration.seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hours, minutes, seconds);
        }

        public override string ToString()
        {
            return $"Hours: {hours} , Minutes: {minutes} , Seconds: {seconds} ";
        }
        #endregion


        #region Overloading
        #region (+,-)
        public static Duration operator +(Duration duration1, Duration duration2)
        {
            return new Duration
            {
                hours = duration1.hours + duration2.hours,
                minutes = duration1.minutes + duration2.minutes,
                seconds = duration1.seconds + duration2.seconds
            };
        }
        public static Duration operator -(Duration duration1, Duration duration2)
        {
            return new Duration
            {
                hours = duration1.hours - duration2.hours,
                minutes = duration1.minutes - duration2.minutes,
                seconds = duration1.seconds - duration2.seconds
            };
        }
        #endregion

        #region ( ( + , - ) , seconds)
        public static Duration operator +(Duration duration, int _seconds)
        {
            return new Duration
            {
                hours = duration.hours + (int)(_seconds / (60 * 60)),
                minutes = duration.Minutes + (int)((_seconds % (60 * 60)) / 60),
                seconds = duration.seconds + (int)((_seconds % (60 * 60)) % 60),
            };
        }
        public static Duration operator +(int _seconds , Duration duration)
        {
            return new Duration
            {
                hours = (int)(_seconds / (60 * 60)) + duration.hours,
                minutes = (int)((_seconds % (60 * 60)) / 60) + duration.Minutes,
                seconds = (int)((_seconds % (60 * 60)) % 60) + duration.seconds
            };
        }
        public static Duration operator -(Duration duration, int _seconds)
        {
            return new Duration
            {
                hours = duration.hours - (int)(_seconds / (60 * 60)),
                minutes = duration.Minutes - (int)((_seconds % (60 * 60)) / 60),
                seconds = duration.seconds - (int)((_seconds % (60 * 60)) % 60),
            };
        }
        public static Duration operator -(int _seconds, Duration duration)
        {
            return new Duration
            {
                hours = (int)(_seconds / (60 * 60)) - duration.hours,
                minutes = (int)((_seconds % (60 * 60)) / 60) - duration.Minutes,
                seconds = (int)((_seconds % (60 * 60)) % 60) - duration.seconds
            };
        }
        #endregion

        #region Unary operator [minutes]
        public static Duration operator ++(Duration duration)
        {
            return new Duration
            {
                hours = duration.Hours,
                minutes = duration.minutes + 1,
                seconds = duration.seconds
            };
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration
            {
                hours = duration.Hours,
                minutes = duration.minutes - 1,
                seconds = duration.seconds 
            };
        }
        #endregion

        #region Relational
        public static bool operator >(Duration duration1,Duration duration2)
        {
            if (duration1.Hours == duration2.Hours)
            {
                return (duration1.Minutes > duration2.Minutes);
            }
            else if (duration1.Minutes == duration2.Minutes)
            {
                return (duration1.seconds > duration2.seconds);
            }
            else
            {
                return (duration1.Hours > duration2.Hours);
            }
        }
        public static bool operator <(Duration duration1, Duration duration2)
        {
            if (duration1.Hours == duration2.Hours)
            {
                return (duration1.Minutes < duration2.Minutes);
            }
            else if (duration1.Minutes == duration2.Minutes)
            {
                return (duration1.seconds < duration2.seconds);
            }
            else
            {
                return (duration1.Hours < duration2.Hours);
            }
        }

        public static bool operator >=(Duration duration1, Duration duration2)
        {
            if (duration1.Hours == duration2.Hours)
            {
                return (duration1.Minutes >= duration2.Minutes);
            }
            else if (duration1.Minutes == duration2.Minutes)
            {
                return (duration1.seconds >= duration2.seconds);
            }
            else
            {
                return (duration1.Hours >= duration2.Hours);
            }
        }
        public static bool operator <=(Duration duration1, Duration duration2)
        {
            if (duration1.Hours == duration2.Hours)
            {
                return (duration1.Minutes <= duration2.Minutes);
            }
            else if (duration1.Minutes == duration2.Minutes)
            {
                return (duration1.seconds <= duration2.seconds);
            }
            else
            {
                return (duration1.Hours <= duration2.Hours);
            }
        }

        public static bool operator true(Duration duration)
        {
            return duration.Hours != 0 || duration.minutes != 0 || duration.seconds !=0;
        }
        public static bool operator false(Duration duration)
        {
            return duration.Hours == 0 || duration.minutes == 0 || duration.seconds == 0;
        }
        #endregion

        #region Casting operators
        public static explicit operator DateTime(Duration duration)
        {
            return DateTime.MinValue
                .AddHours (duration.Hours)
                .AddMinutes (duration.Minutes)
                .AddSeconds (duration.Seconds);
        }
        #endregion
        #endregion
    }
}
