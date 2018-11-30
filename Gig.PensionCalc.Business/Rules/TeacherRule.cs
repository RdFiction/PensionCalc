using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class TeacherRule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfoModel userInfo)
        {
            if (userInfo.Name == "Анна Николаевна")

            {
                pensionInfo.RemainingYears = pensionInfo.RemainingYears.Add(new TimeSpan(-365 * 10, 0, 0, 0));
                pensionInfo.Info += "Скидка учителям - 10 лет" + Environment.NewLine;

            }

            return pensionInfo;

        }
    }
}


