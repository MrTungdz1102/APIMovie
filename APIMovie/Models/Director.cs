using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class Director
{
    public string DirectorId { get; set; } = null!;

    public string DirectorName { get; set; } = null!;

    public string? Story { get; set; }

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();
}
