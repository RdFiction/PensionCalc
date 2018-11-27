using System;

namespace Gig.PensionCalc.Domain.NewFolder1
{
    public class Userinfo
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Места работы
        /// </summary>
        public Work[] Work { get; set; }

    }
}
