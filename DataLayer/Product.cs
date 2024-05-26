using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("ProductTable")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProdName { get; set; }

        public int TotalQty { get; set; }
    }
}
