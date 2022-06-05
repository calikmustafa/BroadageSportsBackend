using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsBackend.Core.Entity2
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public int id { get; set; }
    }
}
