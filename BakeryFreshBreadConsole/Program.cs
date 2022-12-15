using Models;
using System.Reflection;

namespace BakeryFreshBreadConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool toContinue = true;
            var offices = await API.GetList<Office>("https://localhost:7146/api/Office");
            while (toContinue)
            {
                toContinue = await ConsoleMenu.NavigateMenu(ConsoleMenu.ShowMenu(offices), offices);
            }
        }
    }
}