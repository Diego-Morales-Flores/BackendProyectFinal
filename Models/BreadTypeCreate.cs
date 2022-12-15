
namespace Models
{
    public class BreadTypeCreate
    {
        public string BreadName { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string CookingTime { get; set; } = string.Empty;
        public string RestingTime { get; set; } = string.Empty;
        public string FermentTime { get; set; } = string.Empty;
        public int CookingTemperature { get; set; }
        public string Process { get; set; } = string.Empty;
        public ICollection<BreadTypeIngredientCreate> BreadTypeIngredients { get; set; } = new List<BreadTypeIngredientCreate>();

    }
}