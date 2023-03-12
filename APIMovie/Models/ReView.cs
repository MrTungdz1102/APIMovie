using System;
using System.Collections.Generic;

namespace APIMovie.Models;

public partial class ReView
{
    public string ReviewId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime? Date { get; set; }

    public double? Rate { get; set; }

    public string? Content { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<DetailReview> DetailReviews { get; } = new List<DetailReview>();
}
