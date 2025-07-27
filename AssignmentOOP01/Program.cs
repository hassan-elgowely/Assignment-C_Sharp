using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AssignmentOOP01.Employee;

namespace AssignmentOOP01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Part 01

            #region Q1
            /// 1- Create an enum called "WeekDays" with the days of the week (Monday to 
            ///    Sunday) as its members.Then, write a C# program that prints out all the days 
            ///    of the week using this enum.

            //WeekDays days;
            //days = (WeekDays)127;
            //Console.WriteLine(days);

            ///// other way

            //foreach (object day in Enum.GetValues(typeof(WeekDays)))
            //    Console.WriteLine(day);
            #endregion

            #region Q2
            /// 2. Define a struct "Person" with properties "Name" and "Age". Create an array of 
            ///    three "Person" objects and populate it with data. Then, write a C# program to 
            ///    display the details of all the persons in the array. 

            //Person[] user = new Person[3];
            //user[0].AddPerson("ahmed", 20);
            //user[1].AddPerson("mohamed",21);
            //user[2].AddPerson("ibrahim", 22);

            //foreach (object i in user) 
            //    Console.WriteLine(i);
            #endregion

            #region Q3
            /// 3. Create an enum called "Season" with the four seasons (Spring, Summer, 
            ///    Autumn, Winter) as its members.Write a C# program that takes a season 
            ///    name as input from the user and displays the corresponding month range for
            ///    that season. Note range for seasons(spring march to may, summer june to
            ///    august, autumn September to November, winter December to February)


            //Season name;
            //string season;
            //do
            //{
            //    Console.Write("Enter Name Season \nSpring , Summer , Autumn , Winter \n: ");
            //    Enum.TryParse<Season>(season = Console.ReadLine()!, true, out name);
            //} while ((string.IsNullOrWhiteSpace(season)) || (!(season == "Spring" || season == "spring" || season == "Summer" || season == "summer" || season == "Autumn" || season == "autumn" || season == "Winter" || season == "winter")));

            //string message=string.Empty;
            //message = name switch
            //{
            //    Season.Spring => message = "march to may",
            //    Season.Summer => message = "june to august",
            //    Season.Autumn => message = "September to November",
            //    Season.Winter => message = "December to February",
            //          _       => message = "Invalid"
            //};
            //Console.WriteLine(message);
            #endregion

            #region Q4
            /// 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ///    Create Variable from previous Enum to Add and Remove
            ///    Permission from variable, check if specific Permission is existed inside variable

            //Permissions admin ;
            //admin = new Permissions();
            //admin |= Permissions.Write;
            //admin |= Permissions.Read;
            //admin |= Permissions.Delete;
            //admin |= Permissions.Execute;
            //Console.WriteLine(admin);
            //admin &= ~Permissions.Execute;
            //admin &= ~Permissions.Write;
            //Console.WriteLine(admin);
            //admin ^= Permissions.Write;
            //admin ^= Permissions.Execute;
            //Console.WriteLine(admin);

            //if ((admin & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Read is Existed");
            //else Console.WriteLine("Read not Existed");
            #endregion

            #region Q5
            /// 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its 
            ///    members.Write a C# program that takes a color name as input from the user and 
            ///    displays a message indicating whether the input color is a primary color or not.

            //string color = string.Empty;
            //Colors iscolor;
            //do
            //{
            //    Console.Write("Enter Color : ");
            //    Enum.TryParse<Colors>(color = Console.ReadLine()!, true, out iscolor);
            //} while (string.IsNullOrWhiteSpace(color));

            //switch (iscolor)
            //{
            //    case Colors.Red:
            //    case Colors.Blue:
            //    case Colors.Green:
            //        Console.WriteLine("Primary Color");
            //        break;
            //    default:
            //        Console.WriteLine("Not Primary Color");
            //        break;
            //}

            #endregion

            #region Q6
            /// 6. Create a struct called "Point" to represent a 2D point with properties "X" and 
            ///    "Y".Write a C# program that takes two points as input from the user and 
            ///    calculates the distance between them.
            //double x1, y1, x2, y2;
            //bool valid;

            //do
            //{
            //    Console.WriteLine("Enter point 1");
            //    Console.Write("X1 : ");
            //    valid = double.TryParse(Console.ReadLine(), out x1);
            //    Console.Write("Y1 : ");
            //    valid = double.TryParse(Console.ReadLine(), out y1);
            //    Console.WriteLine("Enter point 2");
            //    Console.Write("X2 : ");
            //    valid = double.TryParse(Console.ReadLine(), out x2);
            //    Console.Write("Y2 : ");
            //    valid = double.TryParse(Console.ReadLine(), out y2);
            //}while (!valid);

            //Point p1 = new Point();
            //p1.Vx = x1;
            //p1.Vy = y1;
            //Point p2 = new Point();
            //p2.Vx = x2;
            //p2.Vy = y2;

            //Console.WriteLine(p1.Distance(p2));

            #endregion

            #region Q7
            /// 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# 
            ///    program that takes details of 3 persons as input from the user and displays
            ///    the name and age of the oldest person.

            //int size = 3;
            //PersonQ7[] per = new PersonQ7[size];
            //string name; 
            //int age ;
            //bool parse;
            //for (int i = 0; i < 3 ; i++)
            //{
            //    do
            //    {
            //        Console.Write("Enter Name : ");
            //        name = Console.ReadLine();
            //        Console.Write("Enter Age : ");
            //        parse = int.TryParse(Console.ReadLine(), out age);
            //    } while (!parse || string.IsNullOrEmpty(name));
            //    per[i] = new PersonQ7();
            //    per[i].names = name;
            //    per[i].ages = age;

            //}
            //Array.Sort(per);
            //for (int i = 0; i < per.Length; i++)
            //    Console.WriteLine(per[i]);


            #endregion

            // part 02

            #region Q1
            //Employees[] emp = new Employees[3];
            //Gender Gen;
            //SecurityPrivileges securt;
            //int[] ids = new int[3];
            //int id;
            //string name = string.Empty;
            //decimal salary;
            //string dateD = string.Empty;
            //string dateM = string.Empty;
            //string dateY = string.Empty;
            //string gender = string.Empty;
            //string privileges = string.Empty;

            //for (int i = 0; i < emp.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter ID {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out id) || Array.IndexOf(ids, id) != -1);
            //    ids[i] = id;
            //    do
            //    {
            //        Console.Write("Enter Name : ");
            //        name = Console.ReadLine();
            //    } while (string.IsNullOrEmpty(name));
            //    do
            //    {
            //        Console.Write("Enter Salary : ");
            //    } while (!decimal.TryParse(Console.ReadLine(), out salary));
            //    do
            //    {
            //        Console.WriteLine("Enter Date : ");
            //        Console.Write("Day : ");
            //        dateD = Console.ReadLine();
            //        Console.Write("Month : ");
            //        dateM = Console.ReadLine();
            //        Console.Write("Year : ");
            //        dateY = Console.ReadLine();
            //    } while (string.IsNullOrEmpty(dateD) || string.IsNullOrEmpty(dateM) || string.IsNullOrEmpty(dateY));
            //    do
            //    {
            //        Console.Write("Choose Gender \nMale , M , Female , F \n: ");
            //        Enum.TryParse<Gender>((gender = Console.ReadLine()), true, out Gen);
            //    } while (string.IsNullOrEmpty(gender) || (!(gender == "Male" || gender == "Female" || gender == "M" || gender == "F")));

            //    do
            //    {
            //        Console.Write("Choose Privileges \nGuest, Developer , Secretary , DBA ,  Security Officer \n: ");
            //        Enum.TryParse<SecurityPrivileges>((privileges = Console.ReadLine()), true, out securt);
            //    } while (string.IsNullOrEmpty(privileges) || (!(privileges == "Guest" || privileges == "Developer" || privileges == "Secretary" || privileges == "DBA" || privileges == "SecurityOfficer")));

            //    emp[i] = new Employees();
            //    emp[i].SetId(id);
            //    emp[i].SetName(name);
            //    emp[i].SetSalary(salary);
            //    emp[i].SetHiringDate(new HiringDate(dateD, dateM, dateY));
            //    emp[i].SetGender(Gen);
            //    emp[i].SetSecurityPrivileges(securt);



            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    Console.WriteLine(emp[j]);
            //}
            #endregion

        }
    }
}
