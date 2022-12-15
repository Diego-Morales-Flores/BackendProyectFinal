using Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OrderCreate
    {
        public Guid OfficeID { get; set; }
        public string Descripton { get; set; } = string.Empty;
        public string TotalPrice { get; set; } = string.Empty;
        public ICollection<BreadTypeIngredientCreate> BreadTypeIngredients { get; set; } = new List<BreadTypeIngredientCreate>();
    }
}
