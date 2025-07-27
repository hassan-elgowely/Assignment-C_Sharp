using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01.Employee
{
    internal class HiringDate 
    {
		#region Feilds
		private string Day;
		private string Month;
		private string Year;
		#endregion

		#region New Approach [Getters & Setters]
		public string day
		{
			get { return Day; }
			set { Day = value; }
		}

		public string month
		{
			get { return Month; }
			set { Month = value; }
		}

		public string year
		{
			get { return Year; }
			set { Year = value; }
		}
		#endregion

		#region Old Approach [Getters & Setters]
		public string GetDay()
		{
			return Day;
		}

		public void SetDay(string _day)
		{
			Day = _day;
		}
		public string GetMonth()
		{
			return Month;
		}

		public void SetMonth(string _month)
		{
			Month = _month;
		}
		public string GeYear()
		{
			return Year;
		}

		public void SetYear(string _year)
		{
			Year = _year;
		} 
		#endregion

		#region Constructors
		public HiringDate(string _day, string _month, string _year)
		{
			Day = _day;
			Month = _month;
			Year = _year;
		}
        #endregion

        public override string ToString()
        {
            return $" {Day} / {Month} / {Year} ";
        }
	}
}
