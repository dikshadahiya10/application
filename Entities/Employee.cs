﻿using System;
using System.Collections.Generic;

namespace application.Entities;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmployeeName { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailAddress { get; set; }
}
