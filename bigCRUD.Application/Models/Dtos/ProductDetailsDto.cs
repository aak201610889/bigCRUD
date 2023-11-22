using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models.Dtos
{
    public class ProductDetailsDto
    {

        public int ProductId { get; set; }

        public IFormFile? Image { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
    }
}
