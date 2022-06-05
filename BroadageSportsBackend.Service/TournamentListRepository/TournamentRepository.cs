using BroadageSportsBackend.Core.Entity2;
using BroadageSportsBackend.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Service
{
    public class TournamentRepository : BaseRepository<TournamentList>, ITournamentRepository
    {
        public TournamentRepository(BroadageSportsDbContext context) : base(context)
        {
        }

        public  async Task<IEnumerable<TournamentList>> GetTournamentWithCountryAndParticipantType()
        {
            IEnumerable<TournamentList> tournament = await _context.TournamentList
                .AsNoTracking()
                .Include(v => v.country)
                .Include(y => y.participantType).ToListAsync();

            return tournament;


        }
    }
}
