using System;
using System.Collections.Generic;

namespace BowlingLeague.Models
{
    public partial class TourneyMatches
    {
        public TourneyMatches()
        {
            MatchGames = new HashSet<MatchGames>();
        }

        public long MatchId { get; set; }
        public long? TourneyId { get; set; }
        public string Lanes { get; set; }
        public long? OddLaneTeamId { get; set; }
        public long? EvenLaneTeamId { get; set; }

        public virtual Teams EvenLaneTeam { get; set; }
        public virtual Teams OddLaneTeam { get; set; }
        public virtual Tournaments Tourney { get; set; }
        public virtual ICollection<MatchGames> MatchGames { get; set; }
    }
}
