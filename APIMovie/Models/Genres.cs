using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class Genres
{
    public string GenresId { get; set; } = null!;

    public string GenresName { get; set; } = null!;

    public virtual ICollection<DetailGenres> DetailGenres { get; } = new List<DetailGenres>();
}
