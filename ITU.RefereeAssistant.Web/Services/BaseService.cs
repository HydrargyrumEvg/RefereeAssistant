using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Services
{
    public class BaseService<T> where T : class, IEntity
    {
        public virtual T Get(long Id)
        {
            var session = NHibernateHelper.GetCurrentSession();
            return session
                .Query<T>()
                .Where(entity => entity.Id == Id)
                .FirstOrDefault();            
        }
        public virtual void Save(T entity)
        {
            var session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (var tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }
        public virtual void Delete(T entity)
        {
            var session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(entity);
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public virtual IList<T> GetAll()
        {
            var session = NHibernateHelper.GetCurrentSession();
            var entity = session
                .Query<T>()
                .ToList();
            return entity;
        }

    }
}