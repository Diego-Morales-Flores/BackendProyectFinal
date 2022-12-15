using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BakeryFreshBreadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IDataBaseCrud<Office> _office;
        private readonly IDataBaseCrud<Menu> _menu;
        public OfficeController(IDataBaseCrud<Office> office, IDataBaseCrud<Menu> menu)
        {
            _office = office;
            _menu = menu;
        }

        [HttpGet]
        public async Task<List<Office>> Get()
        {
            return await _office.GetList();
        }

        // GET: api/<IngredientController>
        [HttpPost]
        public async Task<Office> Create([FromBody] Office jsonRequest)
        {
            Office office = new()
            {
                Phone = jsonRequest.Phone,
                Name = jsonRequest.Name,
                Capacity =jsonRequest.Capacity,
                Direcction=jsonRequest.Direcction,
                ListOfOrders=jsonRequest.ListOfOrders,
            };
            var officeCreated = await _office.Create(office);

            foreach (Menu item in jsonRequest.Menu)
            {
                await _menu.Create(new Menu()
                {
                    OfficeID = officeCreated.Id,
                    BreadTypeID = item.BreadTypeID
                });
            }

            return officeCreated;
        }
    }
}
