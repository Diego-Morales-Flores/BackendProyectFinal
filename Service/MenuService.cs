
using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Service
{
    public class MenuService : IDataBaseCrud<Menu>
    {
        private readonly Context _context;

        public MenuService(Context context)
        {
            _context = context;
        }
        public async Task<List<Menu>> GetList()
        {
            return await _context.Menu.ToListAsync();
        }
        public async Task<Menu> Create(Menu menu)
        {
            _context.Add(menu);
            await _context.SaveChangesAsync();
            return menu;
        }

        public Task<Menu> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> Update(Menu entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
