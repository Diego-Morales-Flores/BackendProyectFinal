
namespace Interfaces
{
    public interface IDataBaseCrud<TEntity>
    {
        Task<List<TEntity>> GetList();
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> DeleteById(string id);
    }
}
