namespace Gig.PensionCalc.Domain
{
    /// <summary>
    /// Интерфейс для сохранения в БД
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        long Id { get; set; }
    }
}
