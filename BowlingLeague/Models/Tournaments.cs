using System;
using System.Collections.Generic;

namespace BowlingLeague.Models
{
    public partial class Tournaments
    {
        public Tournaments()
        {
            TourneyMatches = new HashSet<TourneyMatches>();
        }

        public long TourneyId { get; set; }
        public byte[] TourneyDate { get; set; }
        public string TourneyLocation { get; set; }

        public virtual ICollection<TourneyMatches> TourneyMatches { get; set; }
    }
}
