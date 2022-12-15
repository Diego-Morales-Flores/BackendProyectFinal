using DataModel;
using Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Models;
using Service;
namespace BakeryFreshBreadAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>();
            builder.Services.AddTransient<IDataBaseCrud<Ingredient>, IngredientService>();
            builder.Services.AddTransient<IDataBaseCrud<BreadType>, BreadTypeService>();
            builder.Services.AddTransient<IGet<BreadType>, BreadTypeService>();
            builder.Services.AddTransient<IDataBaseCrud<BreadTypeIngredient>, BreadTypeIngredientService>();
            builder.Services.AddTransient<IDataBaseCrud<Office>, OfficeService>();
            builder.Services.AddTransient<IDataBaseCrud<Menu>, MenuService>();
            builder.Services.AddTransient<IDataBaseCrud<Order>, OrderService>();
            builder.Services.AddTransient<IDataBaseCrud<OrderBreadType>, OrderBreadTypeService>();
            builder.Services.AddTransient<IngredientService, IngredientService>();
            builder.Services.AddTransient<IGet<Ingredient>, IngredientService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}