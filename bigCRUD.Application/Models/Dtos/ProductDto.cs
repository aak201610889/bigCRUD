using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models.Dtos
{
    public class ProductDto
    {

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? price { get; set; }
        public IFormFile? ProductImage { get; set; }
        public int CategoryId { get; set; }
    }
}
