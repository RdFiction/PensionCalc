using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business
{
          
    /// <summary>
    /// Правило вычисления пенсии на основе пола
    /// </summary>
    public interface ISexRule : IPensionRule
    {
        /// <summary>
        /// Пол
        /// </summary>

        Sex Sex { get; }
    }
}
