using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public int subtotal { get; set; }

    }
}
