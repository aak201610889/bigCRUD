using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? price { get; set; }
        public byte[] ProductImage { get; set; }
        public int CategoryId { get; set; }

        // Navigation property
        public virtual Category ?Category { get; set; }
    }
}
