using System.ComponentModel.DataAnnotations;

namespace BroadageSportsBackend.Core.Entity2
{
    
        public class Score
        {
            [Key]
            public int ScoreId { get; set; }
            public int id { get; set; }
            public int regular { get; set; }
            public int halfTime { get; set; }
            public int current { get; set; }
        }

}
