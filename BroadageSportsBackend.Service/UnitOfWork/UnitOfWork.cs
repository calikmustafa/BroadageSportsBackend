
using BroadageSportsBackend.Core.Entity2;
using BroadageSportsBackend.Data;
using BroadageSportsBackend.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Service.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly BroadageSportsDbContext _context = new();
        // repository getters
        #region RepositoryGetter
        IBaseRepository<Awayteam> awayTeamRepository;
        IBaseRepository<Country> countryRepository;
        IBaseRepository<Hometeam> homeTeamRepository;
        IBaseRepository<Participanttype> participanttypeRepository;
        IBaseRepository<Round> roundRepository;
        IBaseRepository<Score> scoreRepository;
        IBaseRepository<Score1> score1Repository;
        IBaseRepository<Stage> stageRepository;
        IBaseRepository<Status> statusRepository;
        ITournamentRepository tournamentlistRepository;
        IBaseRepository<Tournament> tournamentRepository;
        #endregion
        #region RepositorySetter
        public IBaseRepository<Awayteam> AwayTeamRepository
        {
            get
            {
                if (awayTeamRepository == null)
                {
                    this.awayTeamRepository = new BaseRepository<Awayteam>(_context);
                }
                return this.awayTeamRepository;
            }
        }
        public IBaseRepository<Status> StatusRepository
        {
            get
            {
                if (statusRepository == null)
                {
                    this.statusRepository = new BaseRepository<Status>(_context);
                }
                return this.statusRepository;
            }
        }

        public IBaseRepository<Score> ScoreRepository
        {
            get
            {
                if (scoreRepository == null)
                {
                    this.scoreRepository = new BaseRepository<Score>(_context);
                }
                return this.scoreRepository;
            }
        }
        public IBaseRepository<Stage> StageRepository
        {
            get
            {
                if (stageRepository == null)
                {
                    this.stageRepository = new BaseRepository<Stage>(_context);
                }
                return this.stageRepository;
            }
        }
        public IBaseRepository<Score1> Score1Repository
        {
            get
            {
                if (score1Repository == null)
                {
                    this.score1Repository = new BaseRepository<Score1>(_context);
                }
                return this.score1Repository;
            }
        }
        public IBaseRepository<Country> CountryRepository
        {
            get
            {
                if (countryRepository == null)
                {
                    this.countryRepository = new BaseRepository<Country>(_context);
                }
                return this.countryRepository;
            }
        }

        public IBaseRepository<Hometeam> HomeTeamRepository
        {
            get
            {
                if (homeTeamRepository == null)
                {
                    this.homeTeamRepository = new BaseRepository<Hometeam>(_context);
                }
                return this.homeTeamRepository;
            }
        }

        public IBaseRepository<Participanttype> ParticipantTypeRepository
        {
            get
            {
                if (participanttypeRepository == null)
                {
                    this.participanttypeRepository = new BaseRepository<Participanttype>(_context);
                }
                return this.participanttypeRepository;
            }
        }
        public ITournamentRepository TournamentlistRepository
        {
            get
            {
                if (tournamentlistRepository == null)
                {
                    this.tournamentlistRepository = new TournamentRepository(_context);
                }
                return this.tournamentlistRepository;
            }
        }
        public IBaseRepository<Round> RoundRepository
        {
            get
            {
                if (roundRepository == null)
                {
                    this.roundRepository = new BaseRepository<Round>(_context);
                }
                return this.roundRepository;
            }
        }







        public IBaseRepository<Tournament> TournamentRepository
        {
            get
            {
                if (tournamentRepository == null)
                {
                    this.tournamentRepository = new BaseRepository<Tournament>(_context);
                }
                return this.tournamentRepository;
            }
        }

       
        #endregion
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}

