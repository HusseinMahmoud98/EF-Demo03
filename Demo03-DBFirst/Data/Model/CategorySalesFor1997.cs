using System;
using System.Collections.Generic;

namespace Demo03_DBFirst.Data.Model;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
