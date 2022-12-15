using Interfaces;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Office : IModificationHistory, IKeyIdentifier
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Direcction { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;

        [NotMapped]
        public ICollection ListOfOrders { get; set; } = new List<Order>();
        [NotMapped]
        public ICollection<Menu> Menu { get; set; } = new List<Menu>();
    }
}
