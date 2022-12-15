using Interfaces;
using Models;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class IngredientService : IDataBaseCrud<Ingredient> , IGet<Ingredient>
    {
        private readonly Context _context;

        public IngredientService(Context context) {
            _context = context;
        }
        public async Task<Ingredient> Create(Ingredient ingredient)
        {
            _context.Add(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;
        }

        public async Task<Ingredient> GetById(string id)
        {
            var response = await _context.Ingredients.FirstOrDefaultAsync(elem => elem.Id.ToString() == id);
            if (response == null)
            { 
                throw new Exception("No existe ese ID"); 
            }
            return response;
        }
        public async Task<Ingredient> GetByName(string name)
        {
            var response = await _context.Ingredients.FirstOrDefaultAsync(elem =>  elem.Name == name);
            if (response == null)
            {
                throw new Exception("No existe ese Name");
            }
            return response;
        }
        public Task<Ingredient> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ingredient>> GetList()
        {
            return await _context.Ingredients.ToListAsync();
        }

        public Task<Ingredient> Update(Ingredient entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
