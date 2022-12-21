using System;
using System.Collections.Generic;

namespace AccessDBDemo.Model2;

public partial class Customer
{
    public int Id { get; set; }

    public string IdentityNo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;
}
