using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gig.PensionCalc.Web.NHibernate
{


    interface IRepository<T> where T : class, IEntity
    {
        /// <summary>
        /// Сохранить сущность
        /// </summary>
        /// <param name="entity"></param>
        void Save(T entity);
        void Delete(T entity);
        T Load(long id);
    }
}
