using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            var age = long.Parse(args[1]);
            var isWoman = bool.Parse(args[2]);
            var pensionage = 65;
            if (isWoman)
            {
                pensionage = 63;
            }
            var result = string.Format("{0}, n=тебе еще работать {1} лет",
                name,
                (pensionage - age);
                )

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
