namespace ACM.Business
{
    /// <summary>
    /// Typed Entity Repository
    /// </summary>
    public interface IRepository<T>: IRetrievable<T>, ISavable<T> where T: class
    {
    }
}