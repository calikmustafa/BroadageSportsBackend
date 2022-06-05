using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BroadageSportsBackend.Core.Entity2
{
   
        public class Hometeam
        {
        
       
        public Score score { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            public string mediumName { get; set; }
            [Key]
        public int HomeTeamId { get; set; }
        public int id { get; set; }
        }

}
