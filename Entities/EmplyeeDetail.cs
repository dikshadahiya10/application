using System;
using System.Collections.Generic;

namespace application.Entities;

public partial class EmplyeeDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? Salary { get; set; }

    public string? Designation { get; set; }
}
