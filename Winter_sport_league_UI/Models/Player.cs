using System;
using System.ComponentModel.DataAnnotations;

namespace Winter_sport_league_UI.Models {
    public class Player {
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        public Guid ClaimId { get; set; }
    }
}
