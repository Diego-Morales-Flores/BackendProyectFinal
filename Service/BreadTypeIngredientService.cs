using Interfaces;
using DataModel;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class BreadTypeIngredientService: IDataBaseCrud<BreadTypeIngredient>
    {
        private readonly Context _context;

        public BreadTypeIngredientService(Context context)
        {
            _context = context;
        }
        public async Task<List<BreadTypeIngredient>> GetList()
        {
            return await _context.BreadTypeIngredients.ToListAsync();
        }
        public async Task<BreadTypeIngredient> Create(BreadTypeIngredient breadIngredient)
        {
            _context.Add(breadIngredient);
            await _context.SaveChangesAsync();
            return breadIngredient;
        }

        public Task<BreadTypeIngredient> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<BreadTypeIngredient> Update(BreadTypeIngredient entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
