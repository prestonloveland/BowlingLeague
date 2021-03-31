using System;
using System.Collections.Generic;

namespace BowlingLeague.Models
{
    public partial class BowlerScores
    {
        public long MatchId { get; set; }
        public long GameNumber { get; set; }
        public long BowlerId { get; set; }
        public long? RawScore { get; set; }
        public long? HandiCapScore { get; set; }
        public byte[] WonGame { get; set; }

        public virtual Bowlers Bowler { get; set; }
    }
}
