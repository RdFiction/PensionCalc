using Gig.PensionCalc.Domain;
using System.Collections.Generic;

namespace gig.PensionCalc.Web.NHibernate
{
    interface IWorkRepository : IRepository<Work>
    {
        /// <summary>
        /// Найти места работы пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        IList<Work> FindByUser(User user);
        void FindByUser();
    }
}
