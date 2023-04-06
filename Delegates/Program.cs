using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegatesExample
    {
        IntIntReturnsInt _del;

        public DelegatesExample(IntIntReturnsInt del)
        {
            _del = del;
        }

        public void AnotherDelegate(IntIntReturnsInt del)
        {
            _del += del;
        }

        public void CallIt()
        {
            _del(10, 5);
        }
    }

    public delegate int IntIntReturnsInt(int a, int b);

    public delegate int VoidReturnInt();

    public delegate void TGenReturnVoid<T>(T x);

    public class Program
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {
            //JustDelegates();

            //Lambdas();

            //FunWithClass();

            IEnumerable<int> outside = GoWithLINQ();
            IEnumerable<int> finalVersion = outside.ToList();
        }

        private static void FunWithClass()
        {
            DelegatesExample x = new DelegatesExample((a, b) => a * b);
            x.AnotherDelegate(SumIt);
            x.AnotherDelegate((a, b) => a - b);
            x.CallIt();
        }

        public static void Lambdas()
        {
            DoSth1(Return10);
            DoSth1(() => 10);
            DoSth2(SumIt);
            DoSth2((q1, q2) => q1 + q2);
            Process(5, 10, (a) => 
            {
                Console.WriteLine(a);
                _log.Info(a);
            }
            );
        }

        public static void Process(int a, int b, TGenReturnVoid<int> output)
        {
            output(a + b);
        }

        public static int Return10()
        {
            return 10;
        }

        public static void DoSth1(VoidReturnInt x)
        {
            Console.WriteLine(x());
        }

        public static int SumIt(int x, int y)
        {
            return x + y;
        }

        public static void DoSth2(IntIntReturnsInt del)
        {
            Console.WriteLine(del(10, 20));
        }

        private static IEnumerable<int> GoWithLINQ()
        {
            List<int> listOfInts = new List<int>();

            listOfInts.Add(1);
            listOfInts.Add(2);
            listOfInts.Add(3);
            listOfInts.Add(4);
            listOfInts.Add(5);
            listOfInts.Add(6);

            IEnumerable<int> result = listOfInts.Where(x => x % 2 == 0).ToList().Where(x => x > 5);

            IEnumerable<int> result2 = from x in listOfInts where x % 2 == 0 select x;

            return result;
        }

        private static bool IsEval(int x)
        {
            return (x % 2) == 0;
        }

        private static void JustDelegates()
        {
            //var x = new TGenReturnVoid(PrintOnConsole);

            Console.WriteLine("Gdzie chcesz logowac? (c/f/a)");
            string ans = Console.ReadLine();
            //if (ans[0] == 'c')
            //    Process(2, 3, PrintOnConsole);
            //else if (ans[0] == 'f')
            //    Process(2, 3, LogMessage);

            TGenReturnVoid<int> del = null;
            if (ans[0] == 'c')
                del = new TGenReturnVoid<int>(PrintOnConsole);
            else if (ans[0] == 'f')
                del = new TGenReturnVoid<int>(LogMessage);
            else if (ans[0] == 'a')
            {
                del += PrintOnConsole;
                del += LogMessage;
            }

            Process(2, 3, del);

            del -= LogMessage;

            Process(3, 4, del);

            PrintSum(Sum);
        }

        public static void PrintOnConsole(int consoleMsg)
        {
            Console.WriteLine(consoleMsg);
        }

        public static void LogMessage(int logMsg)
        {
            _log.Info(logMsg);
        }

        public static void PrintOnPriner(int value)
        {

        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void PrintSum(Func<int, int, int> x)
        {
            Console.WriteLine(x(1, 2));
        }

        public static void PrintSum2(Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> x)
        {
            Console.WriteLine(x(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16));
        }

        public static void PrintSum3(Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> x)
        {
            x(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        }

        public static void AlaMaKota(Func<double> x)
        {
            Console.WriteLine(x());
        }
    }
}
