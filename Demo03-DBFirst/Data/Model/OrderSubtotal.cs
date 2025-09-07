using System;
using System.Collections.Generic;

namespace Demo03_DBFirst.Data.Model;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
