using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Domain
{
    public class TournamentType : IEntity
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string TypeName { get; set; }
    }
}