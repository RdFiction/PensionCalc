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

            Rules = new List<IPensionRule>();

            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            foreach (var typ in types)
            {
                Console.WriteLine($"{typ.Name}");

                var interfaces = typ.GetInterfaces();

                if (typ.IsInterface)
                {
                    Console.WriteLine($" - это интерфейс вообще-то");

                    continue;
                }

                if (typ.IsAbstract)
                {
                    Console.WriteLine($" - это абстрактный класс вообще-то");

                    continue;
                }

                var isPensionRule = false;

                foreach (var intf in interfaces)
                {
                    Console.WriteLine($" - {intf.Name}");

                    if (intf.Name == "IPensionRule")

                    {
                        isPensionRule = true;

                        break;
                    }

                }

                if (isPensionRule)

                {
                    Console.WriteLine($" - это пенсия");

                    var rule = System.Activator.CreateInstance(typ);

                    Rules.Add((IPensionRule)rule);
                }
            }
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

            foreach (var rule in currentRules.OrderBy(cr => cr.Order))
            {
                //применить каждое правило к инфе
                //результат должен быть сквозной
                result = rule.Apply(result, userInfo);
            }

            return result;

        }
    }
}
