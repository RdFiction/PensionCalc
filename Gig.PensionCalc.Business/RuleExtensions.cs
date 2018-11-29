using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    public static class RuleExtensions
    {
        public static void AddInfo(this PensionInfo pensionInfo, string info)

        {

            pensionInfo.Info += $" -- {info} {Environment.NewLine}";

        }
    }
}
