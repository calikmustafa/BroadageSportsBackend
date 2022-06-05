using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Core.Entity2
{
    public class Participanttype
    {
        [Key]
        public int ParticipanttypeId { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }
}
