using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public abstract class BaseRule : IPensionRule
    {
        public virtual string Name => "";

        public virtual int Order => int.MaxValue;

        protected abstract PensionInfo InternalApply(PensionInfo pensionInfo, UserInfo userInfo);

        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userInfo)
        {
            pensionInfo = InternalApply(pensionInfo, userInfo);

            return pensionInfo;
        }
    }
}
