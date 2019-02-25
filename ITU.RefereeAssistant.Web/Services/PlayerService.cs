using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Services
{
    public class PlayerService
    {
        public void Save(Player player)
        {
            var session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(player);
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }
        public void Delete(Player player)
        {
            var session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(player);
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public IList<Player> GetAll()
        {
            var session = NHibernateHelper.GetCurrentSession();
            var players = session
                .Query<Player>()
                .ToList();
            /*model.Player = players;*/
            return players;
        }

    }
}