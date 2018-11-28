using Gig.PensionCalc.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;


namespace Gig.PensionCalc.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор пенсии");

            #region MyRegion

            var user = new UserInfo();

            Console.Write("Напишите ФИО: ");
            user.Name = Console.ReadLine();

            Console.Write("Укажите пол (М/Ж): ");
            string sex = Console.ReadLine();            user.Sex = Sex.Unknown;
            if (sex.ToUpper() == "M" || sex.ToUpper() == "М")
                user.Sex = Sex.Man;
            if (sex.ToUpper() == "Ж")
                user.Sex = Sex.Woman;

            Console.Write("Год рождения: ");
            string year = Console.ReadLine();
            user.BirthDay = Convert.ToDateTime(year);

            var calc = new Calculator();
            var pensionInfo = calc.Calc(user);

            Console.Write(pensionInfo.Info);
            Console.Write("Вы - {0} ({1}), родились в {2} году, вам {3} лет, \nВыход на пенсию в {4} году, Вам осталось работать {5} лет.", user.Name, user.Sex, user.BirthDay.ToShortDateString(), Math.Round(user.Age.TotalDays/365), pensionInfo.PensionDate.ToShortDateString(), Math.Round(pensionInfo.RemainingYears.TotalDays/365));
            
            Console.ReadKey();

            #endregion

        }
    }
}
