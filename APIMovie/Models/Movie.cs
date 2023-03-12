using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class Movie
{
    public string MovieId { get; set; } = null!;

    public string DirectorId { get; set; } = null!;

    public string MovieName { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public double? Duration { get; set; }

    public double? AverageRating { get; set; }

    public long? View { get; set; }

    public string? OverView { get; set; }

    public string? Country { get; set; }

    public virtual Director Director { get; set; } = null!;

    public virtual ICollection<DetailActor> DetailActors { get; } = new List<DetailActor>();

    public virtual ICollection<DetailGenres> DetailGenres { get; } = new List<DetailGenres>();

    public virtual ICollection<DetailReview> DetailReviews { get; } = new List<DetailReview>();
}
