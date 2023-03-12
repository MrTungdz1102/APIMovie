using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string PassWord { get; set; } = null!;

    public bool UserRole { get; set; }

    public bool UserType { get; set; }

    public virtual ICollection<ReView> ReViews { get; } = new List<ReView>();
}
