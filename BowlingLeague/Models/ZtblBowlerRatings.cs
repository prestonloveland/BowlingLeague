using System;
using System.Collections.Generic;

namespace BowlingLeague.Models
{
    public partial class ZtblBowlerRatings
    {
        public string BowlerRating { get; set; }
        public long? BowlerLowAvg { get; set; }
        public long? BowlerHighAvg { get; set; }
    }
}
