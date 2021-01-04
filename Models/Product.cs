using System.ComponentModel.DataAnnotations.Schema;

namespace DbSeedingProductProject.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}