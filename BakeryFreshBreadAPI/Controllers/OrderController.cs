using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;

namespace BakeryFreshBreadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IDataBaseCrud<Order> _order;
        private readonly IDataBaseCrud<OrderBreadType> _orderBreadType;
        private readonly IGet<BreadType> _breadTypeGetService;
        private readonly IDataBaseCrud<OrderBreadType> _breadTypeCrudService;
        public OrderController(IDataBaseCrud<Order> order, IDataBaseCrud<OrderBreadType> orderBreadType, IGet<BreadType> breadTypeGetService, IDataBaseCrud<OrderBreadType> breadTypeCrudService)
        {
            _order = order;
            _orderBreadType = orderBreadType;
            _breadTypeCrudService = breadTypeCrudService;
            _breadTypeGetService = breadTypeGetService;
        }

        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await _order.GetList();
        }

        [HttpPost]
        public async Task<Order> Create([FromBody] OrderCreate jsonRequest)
        {
            Order order = new()
            {
                OfficeID= jsonRequest.OfficeID,
                Descripton= jsonRequest.Descripton,
                TotalPrice= jsonRequest.TotalPrice,
            };
            var orderCreated = await _order.Create(order);

            foreach (var item in jsonRequest.BreadTypeIngredients)
            {
                var bread = await _breadTypeGetService.GetByName(item.Name);

                await _orderBreadType.Create(new OrderBreadType()
                {
                    OrderID = orderCreated.Id,
                    BreadTypeID = bread.Id,
                    Quantity= item.Quantity,
                });
            }

            return orderCreated;
        }
    }
}
