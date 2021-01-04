using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Winter_sport_league_UI.Models;

namespace Winter_sport_league_UI.Data {
    public class PlayerService : IPlayerService {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context) {
            this._context = context;
        }
        public async Task<Player> GetPlayerAsync(IEnumerable<Claim> claims) {
            
                try {
                    var id = claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
                    var athlete = await _context.Players.SingleAsync(x => x.ClaimId == Guid.Parse(id));
                    return athlete;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    return null;
                }
            
        }

        public async Task<Player> AddPlayerAsync(Player player, IEnumerable<Claim> claims) {
          
                try {
                    var id = claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
                    player.ClaimId = Guid.Parse(id);
                    await _context.Players.AddAsync(player);
                    await _context.SaveChangesAsync();
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    return null;
                }
                return player;
           
        }
    }
}
