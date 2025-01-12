using System.ComponentModel.DataAnnotations.Schema;
namespace B2b.EntityLayer
{
    internal class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; }
    }
}
