using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahakBackend.Core.Domain.entities
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public long Name { get; set; }
        public string? ColorId { get; set; }
        public string? IconId { get; set; }
    }
}
