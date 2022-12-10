namespace OPBO.CoreBuisiness
{
    public class Order
    {
        public string Id { get; set; }
        public int BranchCode { get; set; }
        public string  DocNo { get; set; }
        public string FirstName { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal Total { get; set; }

        public OrderPayment Payment { get; set; }

        public OrderAddress Address { get; set; }

        public List<OrderItem> Items { get; set; }

    }
}