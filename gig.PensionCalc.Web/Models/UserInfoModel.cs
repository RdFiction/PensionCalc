using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gig.PensionCalc.Web.Models
{
    public class UserInfoModel
    {

        /// <summary>
        /// ФИО
        /// </summary>
        [Display(Name = "Имя")]
        [MinLength(2)]
        public string Name { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Без даты рождения мы не можем выяснить ничего")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }


        /// <summary>
        /// Пол
        /// </summary>
        [Display(Name = "Пол")]
        [EnumDataType(typeof(Sex))]
        [Required(ErrorMessage = "Очень надо")]
        public Sex Sex { get; set; }

        /// <summary>
        /// Места работы
        /// </summary>
        [Display(Name = "Опыт")]
        public Work[] Work { get; set; }

        /// <summary>
        /// Количество лет
        /// </summary>
        public TimeSpan Age
        {
            get => DateTime.Today - BirthDay;
        }


    }
}