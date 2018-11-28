using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class DefaultRule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userInfo)
        {

            pensionInfo.PensionDate = userInfo.BirthDay.AddYears(65);
            var years = pensionInfo.PensionDate - DateTime.Today;

            pensionInfo.RemainingYears = years;
            pensionInfo.Info += "Стандартный возраст выхода - 65 лет" + Environment.NewLine;

            return pensionInfo;

        }
    }
}


