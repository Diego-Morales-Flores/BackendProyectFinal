using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;

namespace BakeryFreshBreadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreadTypeController : ControllerBase
    {
        private readonly IDataBaseCrud<BreadType> _breadType;
        private readonly IDataBaseCrud<BreadTypeIngredient> _breadTypeIngredient;
        private readonly IDataBaseCrud<Menu> _menu;
        private readonly IngredientService _ingredient;
        public BreadTypeController(IDataBaseCrud<BreadType> breadType,
            IDataBaseCrud<BreadTypeIngredient> breadTypeIngredient,
            IngredientService ingredient,
            IDataBaseCrud<Menu> menu)
        {
            _breadType = breadType;
            _breadTypeIngredient = breadTypeIngredient;
            _ingredient = ingredient;
            _menu = menu;       
        }

        [HttpGet]
        public async Task<List<BreadType>> Get()
        {
            return await _breadType.GetList();
        }

        [HttpGet]
        [Route("office/{offiID}")]
        public async Task<List<BreadType>> GetByOffiID(string offiID)
        {
            var breads = await _breadType.GetList();
            var menus = await _menu.GetList();
            List<BreadType> list = new();
            IEnumerable<BreadType> Query = breads.Where(b => menus.Any(m => m.OfficeID.ToString() == offiID && b.Id==m.BreadTypeID));
            foreach (var i in Query)
            {
                list.Add(i);
            }
            return list;
        }

        [HttpGet]
        [Route("ingredient/{BreadId}")]
        public async Task<List<IngredientsResponse>> GetQuantityIngredients(string BreadId)
        {
            List<IngredientsResponse> result= new();
            var breadTypeIngredient = await _breadTypeIngredient.GetList();
            var breads = breadTypeIngredient.Where(bi => bi.BreadTypeID.ToString() == BreadId);
            foreach (var i in breads) {
                Ingredient response = await _ingredient.GetById(i.IngredientID.ToString());
                result.Add(new IngredientsResponse() {
                Name = response.Name,
                Quantity =i.Quantity
                });
            }
            return result;
        }

        [HttpPost]
        public async Task<BreadType> Create([FromBody] BreadTypeCreate jsonRequest)
        {
            BreadType breadType = new BreadType()
            {
                BreadName = jsonRequest.BreadName,
                Price= jsonRequest.Price,
                CookingTime= jsonRequest.CookingTime,
                CookingTemperature= jsonRequest.CookingTemperature,
                RestingTime= jsonRequest.RestingTime,
                FermentTime= jsonRequest.FermentTime,
                Process= jsonRequest.Process,
            };
            BreadType breadCreated = await _breadType.Create(breadType);

            foreach (BreadTypeIngredientCreate item in jsonRequest.BreadTypeIngredients)
            {
                var ingredient = await _ingredient.GetByName(item.Name);

                if (ingredient == null) {
                    throw new Exception("No Existe");                
                }

                breadCreated.BreadTypeIngredients.Add(await _breadTypeIngredient.Create(new BreadTypeIngredient()
                {
                    BreadTypeID = breadCreated.Id,
                    IngredientID = ingredient.Id,
                    Quantity = item.Quantity
                }));
            }

            return breadCreated;
        }
    }
}
