using System.ComponentModel.DataAnnotations;

namespace BroadageSportsBackend.Core.Entity2
{
    
        public class Score1
        {
            [Key]
        public int Score1Id { get; set; }
        public int id { get; set; }

           
            public int regular { get; set; }
            public int halfTime { get; set; }
            public int current { get; set; }
        }

}
