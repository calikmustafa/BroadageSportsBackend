
using BroadageSportsBackend.Core.Entity2;
using BroadageSportsBackend.Service;
using BroadageSportsBackend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Service.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IBaseRepository<Awayteam> AwayTeamRepository { get; }
        IBaseRepository<Country> CountryRepository { get; }
        IBaseRepository<Hometeam> HomeTeamRepository { get; }
        IBaseRepository<Participanttype> ParticipantTypeRepository { get; }
        IBaseRepository<Round> RoundRepository { get; }
        IBaseRepository<Score> ScoreRepository { get; }
        IBaseRepository<Score1> Score1Repository { get; }
        IBaseRepository<Stage> StageRepository { get; }
        IBaseRepository<Status> StatusRepository { get; }
        ITournamentRepository TournamentlistRepository { get; }
        IBaseRepository<Tournament> TournamentRepository { get; }
        Task<bool> SaveAll();
    }
}
