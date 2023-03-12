using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class Actor
{
    public string ActorId { get; set; } = null!;

    public string? ActorName { get; set; }

    public string? Story { get; set; }

    public virtual ICollection<DetailActor> DetailActors { get; } = new List<DetailActor>();
}
