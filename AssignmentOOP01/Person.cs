using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal struct Person
    {
        private string Name { get; set; }
        private int  Age { get; set; }


        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }

        public void AddPerson(string name, int age)
        {
            if (name != null && age > 0)
            {
                Name = name;
                Age = age;
            }
        }
        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age}";
        }
    }
}
