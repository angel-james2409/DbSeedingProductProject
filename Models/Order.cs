using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbSeedingProductProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int OrderQuantity  { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
