using BroadageSportsBackend.Core.Entity2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Service
{
    public interface ITournamentRepository:IBaseRepository<TournamentList>
    {
        Task<IEnumerable<TournamentList>> GetTournamentWithCountryAndParticipantType();
    }
}
