using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DelSaveResult<T>(T x);

    public class Program
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();

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

        static void Main(string[] args)
        {
            //JustDelegates();

            GoWithLINQ();
        }

        private static void GoWithLINQ()
        {
            List<int> listOfInts = new List<int>();

            listOfInts.Add(1);
            listOfInts.Add(2);
            listOfInts.Add(3);
            listOfInts.Add(4);
            listOfInts.Add(5);
            listOfInts.Add(6);

            IEnumerable<int> result = listOfInts.Where(IsEval);

            foreach (int i in result)
                Console.WriteLine(i);

            List<int> resultList = result.ToList();
            for(int i = 0; i < resultList.Count; i++)
                Console.WriteLine(resultList[i]);
        }

        private static bool IsEval(int x)
        {
            return (x % 2) == 0;
        }

        private static void JustDelegates()
        {
            //var x = new DelSaveResult(PrintOnConsole);

            Console.WriteLine("Gdzie chcesz logowac? (c/f/a)");
            string ans = Console.ReadLine();
            //if (ans[0] == 'c')
            //    Process(2, 3, PrintOnConsole);
            //else if (ans[0] == 'f')
            //    Process(2, 3, LogMessage);

            DelSaveResult<int> del = null;
            if (ans[0] == 'c')
                del = new DelSaveResult<int>(PrintOnConsole);
            else if (ans[0] == 'f')
                del = new DelSaveResult<int>(LogMessage);
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

        public static void Process(int a, int b, DelSaveResult<int> output)
        {
            output(a + b);
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
