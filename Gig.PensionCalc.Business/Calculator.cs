using System.Collections.Generic;
using System.Linq;
using Gig.PensionCalc.Business.Rules;
using Gig.PensionCalc.Domain;


namespace Gig.PensionCalc.Business
{
    public class Calculator
    {
        private IEnumerable<IPensionRule> Rules { get; set; }

        public Calculator()
        {
            Rules = new List<IPensionRule>()
            {

            new DefaultRule(),
            new IsWomanRule(),
            new BirthDay2020Rule(),
            new TeacherRule(),
            
            };

        }
        
        public PensionInfo Calc(UserInfo userInfo)
        {
            var result = new PensionInfo();

            //Правила для текущего человека
            var currentRules = new List<IPensionRule>();


            //собрать все правила Rule

            //Правила по полу
            var sexRules = Rules.OfType<ISexRule>();
            //Все остальные правила
            var otherRules = Rules.Except(sexRules);

            //Правила по полу для текущего человека
            var currentSexRules = sexRules.Where(rule => rule.Sex == userInfo.Sex);


            currentRules.AddRange(otherRules);
            currentRules.AddRange(currentSexRules);

            //вот здесь должен быть цикл по жестким рулам (правила до остальных правил, выход по годам)

            foreach (var rule in currentRules)
            {
                //применить каждое правило к инфе
                //результат должен быть сквозной
                result = rule.Apply(result, userInfo);
            }

            return result;

        }
    }
}
