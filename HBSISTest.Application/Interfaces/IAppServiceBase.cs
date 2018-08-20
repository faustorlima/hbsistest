namespace HBSISTest.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class 
    {
        void Dispose();
    }
}
