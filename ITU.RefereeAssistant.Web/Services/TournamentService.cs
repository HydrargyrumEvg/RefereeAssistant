using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Services
{
    public class TournamentService : BaseService<Tournament>
    {        
        public override IList<Tournament> GetAll()
        {
            var session = NHibernateHelper.GetCurrentSession();
            var entity = session
                .Query<Tournament>()
                .Where(t => t.Author == HttpContext.Current.User.Identity.Name)
                .ToList();
            return entity;
        }
    }
}