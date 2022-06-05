using BroadageSportsBackend.Core.Entity2;
using System.ComponentModel.DataAnnotations;

namespace BroadageSportsBackend.Core.Entity2
{
    



        public class TournamentList
        {
            [Key]
            public int TournamentListId { get; set; }
            public Country country { get; set; }
            public Participanttype participantType { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            public string mediumName { get; set; }
            public string globalName { get; set; }
            public string localName { get; set; }
            public bool isOfficial { get; set; }
            public bool isNational { get; set; }
            public int id { get; set; }
        }

        

        

    }

