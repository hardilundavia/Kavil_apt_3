using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Example p1 = new Example();
            p1.getStack();
            
        }
    }
    class Example
    {    
        public void getStack()
        {
            Stack<int> s1 = new Stack<int>();
            int ch,pop,peek;
            do
            {
                Console.WriteLine("1.push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Peep");
                Console.WriteLine("4.Display");
                Console.WriteLine("5.Count Number");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter Your Choice :");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: Console.WriteLine("Enter Number :");
                            s1.Push(Convert.ToInt32(Console.ReadLine()));
                            break;
                    case 2: pop = s1.Pop();
                            Console.WriteLine("Popped Elements : "+pop);
                            break;
                    case 3: peek=s1.Peek();
                            Console.WriteLine("Peeked Elements : "+peek);
                            break;
                    case 4: foreach (var elem in s1)
                            {
                                Console.WriteLine(elem);
                            }
                            break;
                    case 5: Console.WriteLine(s1.Count());
                            break;
                    default: Console.WriteLine("Invalid Number");
                        break;
                }
            } while (ch != 0);

        }
    }
}
