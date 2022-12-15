using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BakeryFreshBreadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IDataBaseCrud<Ingredient> _ingredient;
        public IngredientController(IDataBaseCrud<Ingredient> ingredient)
        {
            _ingredient = ingredient;
        }

        [HttpGet]
        public async Task<List<Ingredient>> Get()
        {
            return await _ingredient.GetList();
        }

        // GET: api/<IngredientController>
        [HttpPost]
        public async Task<Ingredient> Create([FromBody]Ingredient jsonRequest)
        {
            Ingredient ingredient = new Ingredient()
            {
                Name= jsonRequest.Name,
            };
            return await _ingredient.Create(ingredient);
        }
    }
}
