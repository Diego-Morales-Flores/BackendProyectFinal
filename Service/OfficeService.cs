using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Service
{
    public class OfficeService: IDataBaseCrud<Office>
    {
        private readonly Context _context;

        public OfficeService(Context context)
        {
            _context = context;
        }
        public async Task<Office> Create(Office office)
        {
            _context.Add(office);
            await _context.SaveChangesAsync();
            return office;
        }

        public Task<Office> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Office>> GetList()
        {
            return await _context.Offices.ToListAsync();
        }

        public Task<Office> Update(Office entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
