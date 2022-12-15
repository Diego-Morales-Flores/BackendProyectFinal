

using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Service
{
    public class BreadTypeService: IDataBaseCrud<BreadType>, IGet<BreadType>
    {
        private readonly Context _context;

        public BreadTypeService(Context context)
        {
            _context = context;
        }
        public async Task<List<BreadType>> GetList()
        {
            return await _context.Breads.ToListAsync();
        }
        public async Task<BreadType> Create(BreadType bread)
        {
            _context.Add(bread);
            await _context.SaveChangesAsync();
            return bread;
        }

        public async Task<BreadType> GetById(string id)
        {
            var response = await _context.Breads.FirstOrDefaultAsync(elem => elem.Id.ToString() == id);
            if (response == null)
            {
                throw new Exception("No existe ese ID");
            }
            return response;
        }
        public async Task<BreadType> GetByName(string name)
        {
            var response = await _context.Breads.FirstOrDefaultAsync(elem => elem.BreadName == name);
            if (response == null)
            {
                throw new Exception("No existe ese Name");
            }
            return response;
        }

        public Task<BreadType> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<BreadType> Update(BreadType entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
