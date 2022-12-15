using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Service
{
    public class OrderService : IDataBaseCrud<Order> 
    {
        private readonly Context _context;

        public OrderService(Context context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetList()
        {
            return await _context.Orders.ToListAsync();
        }
        public async Task<Order> Create(Order order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public Task<Order> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Update(Order entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
