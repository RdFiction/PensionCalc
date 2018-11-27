using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор пенсии");

            #region MyRegion

            #endregion //свернуть

            var man = new Userinfo();
            man.Name = name;
            man.Sex = isWoman ? Sex.Woman : Sex.Man;
            man.BirthDay = DateTime.Today.AddYears(-age);

            var calc = new Calculator();
            var pensioninfo = calc.Calc(man);

            
            //var tt = new TimeSpan(23, 2, 56, 34);

            var result = $"{man.Name}, тебе работать еще примерно {pensioninfo.RemainingYears.TotalDays} дней";

            Console.WriteLine(result);

            var now = 2018;
            Console.Write("Напишите имя: ");
            man.Name = Console.ReadLine();

            Console.Write("Напишите фамилию: ");
            string name3 = Console.ReadLine();

            Console.Write("Укажите пол (М/Ж): ");
            string sex = Console.ReadLine();
            //bool sex1 = sex.ToUpper() == "М";
            isWoman = true;
            if  (sex.ToUpper() == "M" || sex.ToUpper() == "М")
                isWoman = false;
            pensionage = isWoman ? 63 : 65;
            
            Console.Write("Год рождения: ");
            string year = Console.ReadLine();
            int year1 = Convert.ToInt32(year);

            int age1 = now - year1;
            int pensionyear = year1 + pensionage;
            int term = pensionyear - now;
           
            Console.Write("Вы - {0} {1}, родились в {2} году, вам {3} лет, \nВыход на пенсию в {4} году, Вам осталось работать {5} лет.", name2, name3, year, age1, pensionyear, term);
            
            Console.ReadKey();
        }
    }
}
