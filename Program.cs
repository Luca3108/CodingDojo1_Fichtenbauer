using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {

        static void Main(string[] args)
        {
           //Stack with Int
            Stack<int> TestInt = new Stack<int>();

            TestInt.Push(4);
            TestInt.Push(3);
            Console.WriteLine("removed {0}",TestInt.Pop());
            
            Console.WriteLine("Peeked {0}", TestInt.Peek());
          


            //Stck with String
            Stack<string> TestString = new Stack<string>();

            TestString.Push("geht´s");
            TestString.Push("Wie");
            TestString.Push("Hallo");
            Console.WriteLine("removed {0}", TestString.Pop());
            Console.WriteLine("removed {0}", TestString.Pop());
            Console.WriteLine("removed {0}", TestString.Pop());
            TestString.Push("Guten Tag");
            Console.WriteLine("Peeked {0}", TestString.Peek());
           


            //Stack with own TestPerson object
            Stack<TestPerson> TestObject = new Stack<TestPerson>();

            TestObject.Push(new TestPerson(21,"Herbert"));
            Console.WriteLine("Peeked {0}", TestObject.Peek());
            TestObject.Push(new TestPerson(99, "Gustav"));
            Console.WriteLine("removed {0}", TestObject.Pop());
            Console.ReadLine();



        }
    }
}
