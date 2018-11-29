using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class TeacherRule : BaseRule
    {
        public override string Name => "Скидка учителям - 10 лет";

        protected override PensionInfo InternalApply(PensionInfo pensionInfo, UserInfo userInfo)

        {
            if (userInfo.Name == "Анна")
            {
                pensionInfo.RemainingYears = pensionInfo.RemainingYears.AddYears(-10);

                pensionInfo.Info += $" * {Name} {Environment.NewLine}";
            }

            return pensionInfo;

        }
    }
}


