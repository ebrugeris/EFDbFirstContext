using System;
using System.Collections.Generic;

namespace EFDbFirstContext.Models;

public partial class AdminUser
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;
}
