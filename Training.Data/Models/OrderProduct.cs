using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

    }
}
