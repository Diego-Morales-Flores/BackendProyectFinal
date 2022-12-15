using System.ComponentModel.DataAnnotations;

namespace Interfaces
{
    public interface IKeyIdentifier
    {
        [Key]
        public Guid Id { get; set; }
    }
}
