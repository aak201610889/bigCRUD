using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models
{
    public class ProductDetails
    {
        public int ID { get; set; }
        public int ProductId { get; set; }

        public byte[] Image { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
    }
}
