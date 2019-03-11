using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Extensions;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Services
{
    public class PlayerService : BaseService<Player>
    {
        public override void Save(Player player)
        {
            var session = NHibernateHelper.GetCurrentSession();
            var playerBD = session
                    .CreateCriteria<Player>()
                    .Add(Restrictions.Eq("Name", player.Name))
                    .List<Player>();
            if (playerBD.Count == 0)
            {
                try
                {

                    using (var tx = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(player);
                        tx.Commit();
                    }
                }
                finally
                {
                    NHibernateHelper.CloseSession();
                }
            }
        }
    }
}