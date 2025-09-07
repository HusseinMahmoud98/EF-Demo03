using System;
using System.Collections.Generic;

namespace Demo03_DBFirst.Data.Model;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
