using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BroadageSportsBackend.Core.Entity2
{
   
        public class Status
        {
            [Key]
            public int StatusId { get; set; }
            public string name { get; set; }
            public string shortName { get; set; }
            

            public int id { get; set; }
       
    }

    
}
