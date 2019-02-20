using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Models
{
    public class User
    {
        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int Age { get; set; }
        [Display(Name = "Имя")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Неверное имя")]
        public string Name { get; set; }
        [Display(Name = "День рождения")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDay {get; set; }
        [Display(Name = "Есть авто")]
        public bool HasAuto {get; set; }
    }
}