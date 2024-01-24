namespace ASPCore_WebMailer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public decimal TotalPrice { get; set; }

        public IEnumerable<OrderProducts> OrderProducts { get; set; }
    }
}
