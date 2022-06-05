using BroadageSportsBackend.Core.Entity2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Data
{
    public class BroadageSportsDbContext:DbContext
    {
        public BroadageSportsDbContext()
        {
        }

        public BroadageSportsDbContext(DbContextOptions<BroadageSportsDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BroadageSportsDb;Trusted_Connection=true");
            }
        }

        public virtual DbSet<Awayteam> awayTeam { get; set; } = null!;
        public virtual DbSet<Soccer> Soccer { get; set; } = null!;
        public virtual DbSet<Hometeam> Hometeam { get; set; } = null!;
        public virtual DbSet<Round> Round { get; set; } = null!;
        public virtual DbSet<Score> Score { get; set; } = null!;
        public virtual DbSet<Score1> Score1 { get; set; } = null!;
        public virtual DbSet<Stage> Stage { get; set; } = null!;
        public virtual DbSet<Status> Status { get; set; } = null!;
        public virtual DbSet<Tournament> Tournament { get; set; } = null!;
        public virtual DbSet<Participanttype> Participanttype { get; set; } = null!;
        public virtual DbSet<Country> Country { get; set; } = null!;
        public virtual DbSet<TournamentList> TournamentList { get; set; } = null!;





    }
}
