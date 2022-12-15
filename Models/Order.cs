using Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Order : IModificationHistory, IKeyIdentifier
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("OfficeId")]
        public Guid OfficeID { get; set; }
        public string Descripton { get; set; } = string.Empty;
        public string TotalPrice { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;



        [NotMapped]
        public virtual ICollection<OrderBreadType> OrderBreadTypes { get; set; } = new List<OrderBreadType>();
    }
}
