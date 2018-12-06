using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gig.PensionCalc.Web.NHibernate.hmpl
{
    public class UserRepository : IUserRepository
    {
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User FindByLogin(string login)
        {
            //Varsession var user - singlordefault / return user
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