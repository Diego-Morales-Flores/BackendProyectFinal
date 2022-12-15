using Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BreadType : IModificationHistory, IKeyIdentifier
    {
        [Key]
        public Guid Id { get; set; }
        public string BreadName { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string CookingTime { get; set; } = string.Empty;
        public string RestingTime { get; set; } = string.Empty;
        public string FermentTime { get; set; } = string.Empty;
        public int CookingTemperature { get; set; }
        public string Process { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;

        [NotMapped]
        public virtual ICollection<BreadTypeIngredient> BreadTypeIngredients { get; set; } = new List<BreadTypeIngredient>();

        [NotMapped]
        public virtual ICollection<OrderBreadType> OrderBreadTypes { get; set; } = new List<OrderBreadType>();

        [NotMapped]
        public virtual ICollection<Menu> Menu { get; set; } = new List<Menu>();

    }
    public enum ProcessTypes
    {
        MixingTheIngredients,
        CutTheDough,
        FoldTheDough,
        LettingTheDoughRest,
        ShapeTheDough,
        LetTheDoughFerment,
        Cook
    };
}