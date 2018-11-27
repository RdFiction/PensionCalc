using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;


namespace Gig.PensionCalc.Business
{
    public class Calculator
    {
        public PensionInfo Calc(UserInfo userInfo)
        {
            var result = new PensionInfo();

            var age = userInfo.Sex == Sex.Woman ? 63 : 65;

            result.PensionDate = userInfo.BirthDay.AddYears(age);

            var years = result.PensionDate - DateTime.Today;

            result.RemainingYears = years;

            //собрать сен правила
            //применить каждое правило к инфе
            //результат должен быть сквозной 
            //как все проверили - формируем результат в человеческом виде

            return result;

        }
    }
}
