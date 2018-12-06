using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gig.PensionCalc.Web.NHibernate.hmpl
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity

    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindByLogin(string login)
        {
            //Varsession var user - singlordefault / return user
            throw new NotImplementedException();
        }

        public T Load(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}