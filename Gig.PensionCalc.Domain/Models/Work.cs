using System;

namespace Gig.PensionCalc.Domain
{

    /// <summary>
    /// Информация о месте работы
    /// </summary>
    public class Work
    {
        /// <summary>
        /// Дата трудоустройства на работу
        /// </summary>
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// Дата увольнения
        /// </summary>
        public DateTime PeriodEnd { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Отчисление за весь период работы
        /// </summary>
        public double Money { get; set; }

    }
}