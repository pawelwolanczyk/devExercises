using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary
{
    internal class UtilsLogger
    {
        static readonly string utilsLogger = "UtilsLogger";

        internal static Logger GetLogger()
        {
            return LogManager.GetLogger(utilsLogger);
        }
    }
}
