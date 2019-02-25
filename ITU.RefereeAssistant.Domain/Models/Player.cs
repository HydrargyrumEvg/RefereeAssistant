using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Player
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }        

        public override string ToString()
        {
            return Name;
        }
    }
}
