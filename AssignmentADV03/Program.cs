using System.Collections;

namespace AssignmentADV03
{
    internal class Program
    {
        #region Q1 FN
        public static void ReserveQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Q2 FN
        public static string CheckElementIsBalance(string element)
        {
            if (element is null)
                return "Not Balance";


            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] == '(' || element[i] == '{' || element[i] == '[')
                    stack.Push(element[i]);

                else if (element[i] == ')' || element[i] == '}' || element[i] == ']')
                {
                    if (stack.Count == 0)
                        return "Not Balanced";

                    else if ((element[i] == ')' && stack.Pop() != '(') || (element[i] == '}' && stack.Pop() != '{') || (element[i] == ']' && stack.Pop() != '['))
                        return "Balanced";
                }
            }
            return stack.Count == 0 ? "Balanced" : "Not Balanced";
        }

        #endregion

        static void Main(string[] args)
        {
            #region Q1
            /// 1.  implement a function to reverse the elements of a queue using a stack.Given a Queue, 

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //foreach (int i in queue)
            //    Console.WriteLine(i);
            //Console.WriteLine("----------------");
            //ReserveQueue(queue);
            //Console.WriteLine("----------------");
            //foreach(int i in queue)
            //    Console.WriteLine(i);

            #endregion

            #region Q2
            /// 2. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack. 
            ///    Ex:
            ///    Input:
            ///    [()] { }
            ///    Output:
            ///    Balanced

            //string element = "[()] {}";
            //Console.WriteLine(CheckElementIsBalance(element));
            #endregion
        }
    }
}
