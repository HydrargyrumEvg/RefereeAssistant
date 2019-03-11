using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Player : IEntity
    {
        public virtual long Id { get; set; }
        [Display(Name = "Название")]
        public virtual string Name { get; set; }        

        public override string ToString()
        {
            return Name;
        }
    }
}
