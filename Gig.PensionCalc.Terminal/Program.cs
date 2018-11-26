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

            var name = args[0];
            var age = long.Parse(args[1]);
            var isWoman = bool.Parse(args[2]);
            var pensionage = 65;
            if (isWoman)
            {
                pensionage = 63;
            }
            var result = string.Format("{0}, тебе работать еще {1} лет",
                name,
                pensionage - age
                );

            //Console.WriteLine(result); 

            var now = 2018;
            Console.Write("Напишите имя: ");
            string name2 = Console.ReadLine();

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
