using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class IsWomanRule : IPensionRule
    {
        public class IsWomanRule : ISexRule
        {
            public Sex Sex => Sex.Woman
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userInfo)
        {
            if (userInfo.Sex == Sex.Woman)

            {
                pensionInfo.RemainingYears = pensionInfo.RemainingYears.Add(new TimeSpan(360 * 2, 0, 0, 0));
                pensionInfo.Info += "Скидка женщинам 2 года" + Environment.NewLine;

            }

            return pensionInfo;

        }
    }
}


