
using Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public  class Ingredient : IModificationHistory, IKeyIdentifier
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;

        [NotMapped]
        public virtual ICollection<BreadTypeIngredient> BreadTypeIngredients { get; set; } = new List<BreadTypeIngredient>();
    }
}
