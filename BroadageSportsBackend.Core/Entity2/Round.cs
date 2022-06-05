using System.ComponentModel.DataAnnotations;

namespace BroadageSportsBackend.Core.Entity2
{
   
        public class Round
        {
            public string name { get; set; }
            public string shortName { get; set; }
            [Key]
            public int RoundId { get; set; }
            public int id { get; set; }
        }

   
}
