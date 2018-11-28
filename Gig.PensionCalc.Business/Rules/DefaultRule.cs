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
            var age = userInfo.Sex == Sex.Woman ? 63 : 65;

            var years = pensionInfo.PensionDate - DateTime.Today;

            pensionInfo.RemainingYears = years;

            return pensionInfo;

        }
    }
}


