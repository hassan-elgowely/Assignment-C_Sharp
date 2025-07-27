using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal struct PersonQ7 : IComparable<PersonQ7>
    {
        private string Name;
        private int Age;


        public string names
        {
            get { return Name; }
            set { Name = value; } 
        }
        public int ages
        { 
            get { return Age ; }
            set { Age = value; }
            
        }

        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age} ";
        }
        public int CompareTo(PersonQ7 other)
        {
            return ages.CompareTo(other.ages);
        }
        
    } 
}
