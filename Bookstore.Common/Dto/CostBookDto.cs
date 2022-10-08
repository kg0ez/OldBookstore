using System;
namespace Bookstore.Common.Dto
{
    public class CostBookDto
    {
        public decimal Price { get; set; }
        public decimal CostDelivery { get; set; }
        public string TimeDelivery { get; set; } = null!;
    }
}

