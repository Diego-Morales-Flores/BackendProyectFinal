using Interfaces;
using Microsoft.Build.Tasks;
using Microsoft.Extensions.Options;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace BakeryFreshBreadConsole
{
    public static class ConsoleMenu
    {
        public static List<OrderCreate> orderList = new();
        public static List<List<OrderCreate>> orderListLimited = new();
        internal async static Task<bool> NavigateMenu(string optionSelected, List<Office> offices)
        {
            if (optionSelected == (offices.Count + 1).ToString())
            {
                PressOpcionN();
                return true;
            }
            if (int.Parse(optionSelected) <= offices.Count && int.Parse(optionSelected) > 0)
            {
                bool sw = true;
                while (sw)
                {
                    sw = await NavigateSubMenu(ShowSubMenu(optionSelected), offices[int.Parse(optionSelected) - 1], optionSelected);
                }
                return true;
            }
            return false;
        }
        public static string ShowMenu(List<Office> offices)
        {
            if (orderListLimited.Count == 0) {
                foreach (var offi in offices)
                {
                    orderListLimited.Add(new List<OrderCreate>());
                }
            }
            string options = "";
            int count = 1;
            foreach (var item in offices)
            {
                options += $"{count}. {item.Name}\n";
                count++;
            }
            Console.WriteLine(
                "Bakery Fresh Bread \n" +
                "------------------------------------- \n" +
                options +
                $"{count}. Get All Orders \n" +
                "------------------------------------- \n");
            var option = Console.ReadLine();
            option ??= string.Empty;
            return option;
        }

        internal async static Task<bool> NavigateSubMenu(string option, Office office, string offiSelected)
        {
            if (option == "1")
            {
                await CreateOrderMenu(office, offiSelected);
                return true;
            }
            if (option == "2")
            {
                if (ThereAnyIsOrders(offiSelected) != string.Empty)
                {
                    await MakeOrders(offiSelected, office.Id.ToString());
                }
                ;
                return true;
            }
            return false;
        }

        private static string ShowSubMenu(string option)
        {
            string option2 = ThereAnyIsOrders(option);
            Console.WriteLine(
                "Bakery Fresh Bread \n" +
                "------------------------------------- \n" +
                "1. Add order\n" +
                $"{option2}" +
                "Press any other key to Go back to the main menu\n" +
                "------------------------------------- \n");
            string optionSelected = Console.ReadLine() ?? "";
            return optionSelected;
        }

        private async static Task<bool> MakeOrders(string offiSelected, string offiId)
        {
            List<BreadType> breadtypes = await API.GetList<BreadType>($"https://localhost:7146/api/BreadType/office/{offiId}");
            foreach (var order in orderListLimited[int.Parse(offiSelected)-1])
            {
                Console.WriteLine($"Realizando la orden {order.OfficeID} : {order.Descripton}");
                foreach (var item in order.BreadTypeIngredients)
                {
                    BreadType bread= breadtypes.Find(b => b.BreadName==item.Name);
                    await BreadProces(item.Quantity , bread);
                }
                orderListLimited[int.Parse(offiSelected)-1] = new List<OrderCreate>();
            }
            return true;
        }

        private async static Task<bool> CreateOrderMenu(Office office, string offiSelected)
        {
            List<BreadType> breadtypes = await API.GetList<BreadType>($"https://localhost:7146/api/BreadType/office/{office.Id}");
            bool sw = true;
            List<BreadTypeIngredientCreate> ordersList = new();
            double totalPrice = 0.0;
            int quantity = 0;
            while (sw)
            {
                Console.WriteLine("Orden Actual:");
                foreach (var item in ordersList)
                {
                    Console.WriteLine($"{item.Name}s: {item.Quantity}");
                }

                Console.WriteLine("Bakery Fresh Bread \n" +
                    "------------------------------------- \n");
                for (int i = 0; i < breadtypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {breadtypes[i].BreadName}");
                }
                Console.WriteLine($"{breadtypes.Count + 1}. Realizar Orden");
                string option = Console.ReadLine() ?? string.Empty;

                if (int.Parse(option) == breadtypes.Count + 1)
                {
                    AcceptOrder(ordersList, office, totalPrice, quantity, offiSelected);
                    sw = false;
                }
                else
                {
                    var result = CreateOrder(breadtypes[int.Parse(option) - 1]);
                    ordersList.Add(result.order);
                    totalPrice += result.price;
                    quantity += result.quantity;
                }
            }
            return sw;
        }

        private static (BreadTypeIngredientCreate order, double price, int quantity) CreateOrder(BreadType breadType)
        {
            Console.WriteLine($"Ingrese la cantidad de {breadType.BreadName}s");
            string BreadQuantity = Console.ReadLine();
            return (new BreadTypeIngredientCreate()
            {
                Name = breadType.BreadName,
                Quantity = int.Parse(BreadQuantity)
            }, int.Parse(BreadQuantity) * double.Parse(breadType.Price), int.Parse(BreadQuantity));
        }

        private async static void AcceptOrder(List<BreadTypeIngredientCreate> list, Office office, double totalPrice, int quantity, string offiSelected)
        {
            int count = Cont(orderListLimited[int.Parse(offiSelected) - 1]);
            if (quantity + count > office.Capacity)
            {
                Console.WriteLine($"La orden pasa el limite de capacidad para la {office.Name}\n" +
                    $"Canditad Disponible: {office.Capacity - count}"
                    );
                return;
            }
            Console.WriteLine("Ingrese una descripccion (opcional):");
            string description = Console.ReadLine() ?? "";
            OrderCreate order = new()
            {
                OfficeID = office.Id,
                TotalPrice = totalPrice.ToString(),
                Descripton = description,
                BreadTypeIngredients = list
            };
            ;
            if (await AreYouSure())
            {
                orderList.Add(order);
                orderListLimited[int.Parse(offiSelected) - 1].Add(order);
                var response = await API.Create("https://localhost:7146/api/Order", order);
                Console.WriteLine($"El precio total es de: {totalPrice}$");
            }
        }

        // Utils 

        private static async Task<bool> BreadProces(int quantity, BreadType? bread)
        {
            List<IngredientsResponse> ingredients = await API.GetList<IngredientsResponse>($"https://localhost:7146/api/BreadType/ingredient/{bread.Id}");
            var processes = bread.Process.Split(", ");
            foreach (var process in processes)
            {
                switch (process)
                {
                    case "MIX":
                        Console.WriteLine(Mix(ingredients));
                        break;
                    case "REST":
                        Console.WriteLine($"Let the dough rest {bread.RestingTime}.");
                        break;
                    case "CUT":
                        if(quantity>1)Console.WriteLine("Cut the dough");
                        break;
                    case "FOLD":
                        Console.WriteLine("Fold the dough");
                        break;
                    case "FERMENT":
                        Console.WriteLine($"Let the dough ferment {bread.FermentTime}.");
                        break;
                    case "SHAPE":
                        Console.WriteLine("Shape the dough");
                        break;
                    case "COOK":
                        Console.WriteLine($"Cook for {bread.CookingTime} at {bread.CookingTemperature}º");
                        break;
                    case "PLACE":
                        Console.WriteLine($"- Place on top of the dough the seamed seen and the gilding.");
                        break;
                    default:
                        // code block
                        break;
                }
            }
            return true;
        }

        private static string Mix(List<IngredientsResponse> ingredients)
        {
            var last = ingredients.Last();
            string result = "Mixing the ";
            foreach (var ingredient in ingredients)
            {
                if (!ingredient.Equals(last))
                {
                    result += $"{ingredient.Quantity}g of {ingredient.Name},";
                }
                else {
                    result = result.Remove(result.Length - 1);
                    result += $" and {ingredient.Quantity}g of {ingredient.Name}.";
                }
                
            }
            return result;
        }

        private async static Task<bool> AreYouSure()
        {
            bool sw = false;
            Console.WriteLine("Desea realizar la orden? (si/no)");
            string answer = Console.ReadLine();
            if (answer == "si")
                sw = true;
            if (answer == "no")
                sw = false;
            await Task.Delay(0);
            return sw;
        }

        private static int Cont(List<OrderCreate> orderCreates)
        {
            int count = 0;
            foreach (OrderCreate order in orderCreates)
            {
                foreach (var item in order.BreadTypeIngredients)
                {
                    count += item.Quantity;
                }
            }
            return count;
        }

        private static string ThereAnyIsOrders(string optionSelected) {
            if (orderListLimited[int.Parse(optionSelected)-1].Count == 0){  
                return string.Empty;
            }
            return "2. Prepare all the orders \n";
        }
        private static void PressOpcionN()
        {
            double totalMoney = 0;
            foreach (var order in orderList)
            {
                foreach (var item in order.BreadTypeIngredients)
                {
                    Console.WriteLine($"{item.Name}s x {item.Quantity}");
                }
                totalMoney += double.Parse(order.TotalPrice);
            }
            Console.WriteLine($"Total ganado: {totalMoney}$");
        }

    }
}
