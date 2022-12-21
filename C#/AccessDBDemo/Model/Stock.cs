using System;
using System.Collections.Generic;

namespace AccessDBDemo.Model;

public partial class Stock
{
    public int Id { get; set; }

    public int MetarialCode { get; set; }

    public string? Description { get; set; }

    public int Unit { get; set; }

    public DateTime CreateDateTime { get; set; }
}
