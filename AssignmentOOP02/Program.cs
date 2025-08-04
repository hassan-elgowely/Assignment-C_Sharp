using First_Project;
using Second_Project;
using Third_Project;
using System.Drawing;
namespace AssignmentOOP02

{

    internal class Program
    {
        static void Main(string[] args)
        {


            #region First project

            #region Q2
            /// 2. Override the ToString Function to produce this output: 

            //Point3D p = new Point3D(10, 10, 10);
            //Console.WriteLine(p.ToString());
            #endregion

            #region Q3
            /// 3.  Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert). 
            //int x1, y1, z1;
            //bool flag1;
            //Console.WriteLine("Enter point 1");
            //do
            //{
            //    Console.Write("X : ");
            //    flag1 = int.TryParse(Console.ReadLine(), out x1);
            //    Console.Write("Y : ");
            //    flag1 = int.TryParse(Console.ReadLine(), out y1);
            //    Console.Write("Z : ");
            //    flag1 = int.TryParse(Console.ReadLine(), out z1);
            //}while (!flag1);
            //Point3D p1 = new Point3D(x1, y1, z1);

            //int x2, y2, z2;
            //bool flag2;
            //Console.WriteLine("Enter point 2");
            //do
            //{
            //    Console.Write("X : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out x2);
            //    Console.Write("Y : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out y2);
            //    Console.Write("Z : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out z2);
            //} while (!flag2);
            //Point3D p2 = new Point3D(x2, y2, z2);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2); 
            #endregion

            #region Q4
            /// 4. Try to use == If(P1 == P2)   Does it work properly? 
            //if (p1 == p2)
            //    Console.WriteLine("p1 Equal p2");
            //else
            //    Console.WriteLine("p1 not Equal p2"); 
            #endregion

            #region Q6
            /// 5. Define an array of points and sort this array based on X & Y coordinates.

            //Point3D[] points = new Point3D[5];
            //points[0] = new Point3D(1, 8, 6);
            //points[1] = new Point3D(4, 4, 13);
            //points[2] = new Point3D(11, 5, 14);
            //points[3] = new Point3D(2, 3, 4);
            //points[4] = new Point3D(7, 9, 6);


            //foreach (var i in points)
            //    Console.WriteLine(i);

            //Point3D.SortArrByXY(points);

            //foreach (var i in points)
            //    Console.WriteLine(i); 
            #endregion

            #region Q7
            /// 6. Implement ICloneable interface to be able to clone the object.

            //Point3D point = new Point3D(7, 15, 9);

            //Console.WriteLine(point.Clone());

            #endregion

            #endregion



            #region Second Project
            /// Define Class Maths that has four methods: Add, Subtract, Multiply, 
            /// and Divide, each of them takes two parameters.Call each method in Main().
            /// Modify the program so that you do not have to create an instance
            /// of class to call the four methods.

            //decimal num01, num02;
            //do
            //{
            //    Console.Write("Enter Number 01 : ");
            //} while (!decimal.TryParse(Console.ReadLine(), out num01));
            //do
            //{
            //    Console.Write("Enter Number 02 : ");
            //} while (!decimal.TryParse(Console.ReadLine(), out num02));

            //Console.WriteLine($"num01 - num02 = { Maths.Subtract(num01, num02)}");
            //Console.WriteLine($"num01 + num02 = {Maths.Add(num01 , num02)}");
            //Console.WriteLine($"num01 * num02 = {Maths.Multiply(num01 , num02)}");
            //Console.WriteLine($"num01 / num02 = {Maths.Divide(num01 , num02)}");
            #endregion



            #region Third Project

            #region Q2
            /// 2. Override All System.Object Members (ToString, Equals,GetHasCode) . 

            //Duration duration01 = new Duration();
            //Duration duration02 = new Duration();
            //duration01.Hours = 23;
            //duration02.Hours = 23;
            //duration01.Minutes = 30;
            //duration02.Minutes = 30;
            //duration01.Seconds = 5;
            //duration02.Seconds = 5;
            //duration01.Equals(duration02);
            //Console.WriteLine($"Duration01 : {duration01.ToString()}");
            //Console.WriteLine($"Duration01 Hash Code : {duration01.GetHashCode()}");
            //Console.WriteLine($"Duration02 : {duration02.ToString()}");
            //Console.WriteLine($"Duration02 Hash Code : {duration02.GetHashCode()}");

            #endregion

            #region Q3
            /// 3. Define All Required Constructors to Produce this output:

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());

            #endregion

            #region Q4
            /// 4. Implement All required Operators overloading to enable this Code: 

            //Duration D1 = new Duration(1,10,15);
            //Duration D2 = new Duration(1,5,7);
            //Duration D3 = new Duration();


            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D1;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D2;
            //Console.WriteLine(D2);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //D1 = new Duration(1, 10, 15);

            //if (D1>D2)
            //    Console.WriteLine("D1 is greater than D2");
            //else
            //    Console.WriteLine("D1 is not greater than D2");

            //if (D1 >= D2)
            //    Console.WriteLine("D1 is grater than or equal D2");
            //else
            //    Console.WriteLine("D1 is not grater than or equal D2");

            //D1 = new Duration();
            //if (D1)
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");

            //D1 = new Duration(1, 10, 15);
            //DateTime obj = (DateTime)D1;
            //Console.WriteLine(obj);

            #endregion

            #endregion


        }
    }
}
