using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class BirthDay2020Rule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfoModel userInfo)
        {
            if (userInfo.Sex == Sex.Man && userInfo.BirthDay.Year == 1959)

            {
                pensionInfo.RemainingYears = new DateTime(2020, 1, 1) - DateTime.Today;
                pensionInfo.Info += "Успел родиться в 1959, выходи в 2020" + Environment.NewLine;

            }

            if (userInfo.Sex == Sex.Woman && userInfo.BirthDay.Year == 1964)

            {
                pensionInfo.RemainingYears = new DateTime(2020, 1, 1) - DateTime.Today;
                pensionInfo.Info += "Успела родиться в 1964, выходи в 2020" + Environment.NewLine;

            }
            return pensionInfo;
        
        }
    }
}


