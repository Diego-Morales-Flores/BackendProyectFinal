
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Interfaces;

namespace Models
{
    public class BreadTypeIngredient : IModificationHistory
    {
        [Key, Column(Order = 0)]
        public Guid BreadTypeID { get; set; }
        [Key, Column(Order = 1)]
        public Guid IngredientID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
