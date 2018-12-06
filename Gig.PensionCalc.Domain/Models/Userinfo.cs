using System;

namespace Gig.PensionCalc.Domain
{
    public class UserInfoModel : IEntity
    {

        public virtual long Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public virtual DateTime BirthDay { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public virtual Sex Sex { get; set; }

        /// <summary>
        /// Места работы
        /// </summary>
        public virtual Work[] Work { get; set; }

        /// <summary>
        /// Количество лет
        /// </summary>
       public virtual TimeSpan Age
       {
            get => DateTime.Today - BirthDay;
       }

    }
}
