using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01.Employee
{
    internal class Employees
    {
        #region Feilds
        private int Id;
        private string Name;
        public decimal Salary;
        public HiringDate HiringDate;
        public Gender GenderG;
        public SecurityPrivileges Privileges;
        #endregion




        #region New Approach [Getters & Setters]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public decimal salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public HiringDate hiringDate
        {
            get { return HiringDate; }
            set { HiringDate = value; }
        }

        public Gender gender
        {
            get { return GenderG; }
            set { GenderG = value; }
        }

        public SecurityPrivileges privileges
        {
            get { return Privileges; }
            set { Privileges = value; }
        }
        #endregion




        #region Old Approach [Getters & Setters]
        public int GetId()
        {
            return Id;
        }
        public void SetId(int _id)
        {
            Id = _id;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string _name)
        {
            Name = _name;
        }

        public decimal GetSalary()
        {
            return Salary;
        }
        public void SetSalary(decimal _salary)
        {
            Salary = _salary;
        }

        public HiringDate GetHiringDate()
        {
            return HiringDate;
        }
        public void SetHiringDate(HiringDate _hiringDate)
        {
            HiringDate = _hiringDate;
        }

        public Gender GetGender()
        {
            return GenderG;
        }
        public void SetGender(Gender _gender)
        {
            GenderG = _gender;
        }

        public SecurityPrivileges GetSecurityPrivileges()
        {
            return Privileges;
        }
        public void SetSecurityPrivileges(SecurityPrivileges _Privileges)
        {
            Privileges = _Privileges;
        }
        #endregion




        #region Constructors
        public Employees(int _id, string _name, decimal _salary, HiringDate _hiringDate, Gender _gender , SecurityPrivileges _Privileges)
        {
            if (_id == 0 && _name is not null && _salary > 7000 && _hiringDate is not null && (_gender == Gender.F ||_gender == Gender.M || _gender == Gender.Male || _gender == Gender.Female ) && (_Privileges == SecurityPrivileges.guest|| _Privileges == SecurityPrivileges.Developer || _Privileges == SecurityPrivileges.secretary|| _Privileges == SecurityPrivileges.DBA|| _Privileges == SecurityPrivileges.SecurityOfficer))
            {
                Id = _id;
                Name = _name;
                Salary = _salary;
                HiringDate = _hiringDate;
                GenderG = _gender;
                Privileges = _Privileges;
            }
        }
        public Employees() { }
        #endregion


        public override string ToString()
        {
            return string.Format("ID : {0} \nName : {1} \nSalary : {2:C} \nHiringDate : {3} \nGender : {4} \nPrivileges : {5} ", Id , Name , Salary , HiringDate , GenderG , Privileges) ;
        }
        

    }
}
