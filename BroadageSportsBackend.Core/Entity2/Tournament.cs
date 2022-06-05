using System.ComponentModel.DataAnnotations;

namespace BroadageSportsBackend.Core.Entity2
{
    
        public class Tournament
        {
            [Key]
            public int TournamentId { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            
            public int id { get; set; }
        }

    
}
