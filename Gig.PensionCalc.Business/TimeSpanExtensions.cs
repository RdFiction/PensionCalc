using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    /// <summary>
    /// Расширение класса <see cref="TimeSpan"/>
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Добавить годы к <see cref="TimeSpan"/>
        /// </summary>

        /// <param name="time">Объект <see cref="TimeSpan"/></param>

        /// <param name="years">Количество лет</param>

        /// <returns></returns>

        public static TimeSpan AddYears(this TimeSpan time, int years)
        {
            var addDays = years % 4;

            return time.Add(new TimeSpan(years * 365 + addDays, 0, 0, 0));
        }
    }
}
