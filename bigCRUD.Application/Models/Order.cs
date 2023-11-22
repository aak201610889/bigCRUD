

namespace bigCRUD.Application.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public DateTime orderDate { get; set; }
        public string status { get; set; }
        public string shippingAddress { get; set; }

    }
}
