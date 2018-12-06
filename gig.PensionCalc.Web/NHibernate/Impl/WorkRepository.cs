using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gig.PensionCalc.Web.NHibernate.hmpl
{
    public class WorkRepository : IWorkRepository
    {
        /// <summary>
        /// Найти места работы пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        public IList<Work> FindByUser(User user)
{
            throw new NotImplementedException();
        }
        public void FindByUser()
        {
            throw new NotImplementedException();
}

public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User FindByLogin(string login)
        {
            //Varsession var works - session tolist / return works
            throw new NotImplementedException();
        }

        public User Load(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(User entity)
        {
            throw new NotImplementedException();
        }
    }
}