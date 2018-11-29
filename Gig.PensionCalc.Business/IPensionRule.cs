using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business
{
    /// <summary>
    /// Правило вычисления пенсии
    /// </summary>
    public interface IPensionRule
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Порядок
        /// </summary>
        int Order { get; }


        /// <summary>
        /// Применить правило
        /// </summary>
        /// <param name="pensionInfo">Информация о пенсии</param>

        /// <param name="userInfo">Информация о человеке</param>

        /// <returns>Измененная информация о пенсии</returns>
                PensionInfo Apply(PensionInfo pensionInfo, UserInfo userInfo);

    }
}
