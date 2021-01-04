using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Winter_sport_league_UI.Models;

namespace Winter_sport_league_UI.Data {
    public interface IPlayerService {
        public Task<Player> GetPlayerAsync(IEnumerable<Claim> claims);
        public Task<Player> AddPlayerAsync(Player player, IEnumerable<Claim> claims);
    }
}
