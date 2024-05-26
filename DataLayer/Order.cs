using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("OrderTable")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string OrderName { get; set; }

        public int ProductId { get; set; }

        public DateTime OrderTime { get; set; }

        public string OrderStatus { get; set; }
    }
}
