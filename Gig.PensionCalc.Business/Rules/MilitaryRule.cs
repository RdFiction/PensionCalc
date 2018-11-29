using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class MilitaryRule : BaseRule
            {
        public override string Name => "Скидка воякам - 1 год";

        protected override PensionInfo InternalApply(PensionInfo pensionInfo, UserInfo userInfo)
        {
            if (userInfo.Name == "Олег")
            {
                pensionInfo.RemainingYears = pensionInfo.RemainingYears.AddYears(-2);

                pensionInfo.Info += $" * {Name} {Environment.NewLine}";
            }

            return pensionInfo;

        }
    }
}
