using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class IsWomanRule : BaseRule, ISexRule
    {
        public Sex Sex => Sex.Woman;

        public override string Name => "Скидка дамам - 2 года";

        protected override PensionInfo InternalApply(PensionInfo pensionInfo, UserInfo userInfo)
        {
            pensionInfo.RemainingYears = pensionInfo.RemainingYears.AddYears(-2);

            pensionInfo.Info += $" * {Name} {Environment.NewLine}";

            return pensionInfo;

        }

    }

}

