using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BroadageSportsBackend.Core.Entity2
{
    
        public class Awayteam
        {
            [ForeignKey("Score1")]
           
            public int Score1ID { get; set; }
            public Score1 score { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            public string mediumName { get; set; }
            [Key]
            public int id { get; set; }
        }

}
