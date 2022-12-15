using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Service
{
    public class OrderBreadTypeService : IDataBaseCrud<OrderBreadType>
    {
        private readonly Context _context;

        public OrderBreadTypeService(Context context)
        {
            _context = context;
        }
        public async Task<List<OrderBreadType>> GetList()
        {
            return await _context.OrderBreadTypes.ToListAsync();
        }
        public async Task<OrderBreadType> Create(OrderBreadType orderBreadType)
        {
            _context.Add(orderBreadType);
            await _context.SaveChangesAsync();
            return orderBreadType;
        }

        public Task<OrderBreadType> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderBreadType> Update(OrderBreadType entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
