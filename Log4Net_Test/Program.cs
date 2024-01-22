using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net_Test
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Hello logging world!");
            log.Debug("Hello logging world!");

            // Test commit dev

            // Test quality

            Console.WriteLine("Hit enter");
            Console.ReadLine();
        }
    }
}
