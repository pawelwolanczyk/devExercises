using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();

        public delegate void DelSaveResult(int x);

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
            IPrinter x = new FilePrinter();
            x.Printer.Print(0);
            //var x = new DelSaveResult(PrintOnConsole);

            Console.WriteLine("Gdzie chcesz logowac? (c/f)");
            string ans = Console.ReadLine();
            //if (ans[0] == 'c')
            //    Process(2, 3, PrintOnConsole);
            //else if (ans[0] == 'f')
            //    Process(2, 3, LogMessage);

            DelSaveResult del = null;
            if (ans[0] == 'c')
                del = new DelSaveResult(PrintOnConsole);
            else if (ans[0] == 'f')
                del = new DelSaveResult(LogMessage);

            Process(2, 3, del);

        }

        public static void Process(int a, int b, DelSaveResult output)
        {
            output(a + b);
        }

        public static void Process(int a, int b, IPrinter output)
        {
            output.Print(a + b);
        }

        public interface IPrinter
        {
            IPrinter Printer { get; set; }

            void Print(int x);
        }

        public class FilePrinter : IPrinter
        {
            public IPrinter Printer { get; set; }

            public void Print(int x)
            {
                _log.Info(x);
            }
        }
    }
}
