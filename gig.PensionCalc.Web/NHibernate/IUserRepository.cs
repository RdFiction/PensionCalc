namespace gig.PensionCalc.Web.NHibernate
{
    interface IUserRepository : IRepository<User>
    {
        User FindByLogin(string login);
    }
}
