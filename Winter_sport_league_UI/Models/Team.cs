using System.ComponentModel.DataAnnotations.Schema;

namespace Winter_sport_league_UI.Models {
    public class Team {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int TeamWinCount { get; set; }
        public int TeamDrawCount { get; set; }
        public int TeamLoseCount { get; set; }

        [ForeignKey("Player_ID")]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
