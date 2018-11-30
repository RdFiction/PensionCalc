using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class IsWomanRule : ISexRule
    {
        public Sex Sex => Sex.Woman;

        public PensionInfo Apply(PensionInfo pensionInfo, UserInfoModel userinfo)

        {

            pensionInfo.RemainingYears = pensionInfo.RemainingYears.Add(new TimeSpan(-365 * 2, 0, 0, 0));
            pensionInfo.PensionDate = DateTime.Today.Add(pensionInfo.RemainingYears);


            pensionInfo.Info += "Скидка дамам - 2 года" + Environment.NewLine;


            return pensionInfo;

        }

    }

}

