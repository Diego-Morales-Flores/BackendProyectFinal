
namespace Interfaces
{
    public interface IGet<TEntity>
    {
        public Task<TEntity> GetById(string id);

        public Task<TEntity> GetByName(string name);
   
    }
}
