﻿using System;
using System.Collections.Generic;

namespace EntityFrameWorkNET23KA.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Email { get; set; } = null!;
}
