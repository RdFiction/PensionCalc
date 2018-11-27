using Gig.PensionCalc.Domain.Models;
using Gig.PensionCalc.Domain.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    public class Calculator
    {
        public PensionInfo Calc(Userinfo userinfo)
        {
            var result = new PensionInfo();

            var age = userinfo.Sex = Sex.Woman ? 63 : 65;

            var years = userinfo.BirthDay.AddYears(age) - DateTime.Today;

            result.RemainingYears = years;

            //собрать сен правила
            //применить каждое правило к инфе
            //результат должен быть сквозной 
            //как все проверили - формируем результат в человеческом виде

            return result;

        }
    }
}
