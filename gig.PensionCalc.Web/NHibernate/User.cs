using Gig.PensionCalc.Domain;

namespace gig.PensionCalc.Web.NHibernate
{
    public class User : IEntity
    {
        //ID Login password
        public virtual long Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }

    }
}