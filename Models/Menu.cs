using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Menu : IModificationHistory
    {
        [Key, Column(Order = 0)]
        public Guid OfficeID { get; set; }
        [Key, Column(Order = 1)]
        public Guid BreadTypeID { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
