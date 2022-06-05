 namespace BroadageSportsBackend.Core.Entity2
{
   
        public  class Soccer
        {
            public Hometeam homeTeam { get; set; }
            public Awayteam awayTeam { get; set; }
            public Status status { get; set; }
            public Tournament tournament { get; set; }
            public Stage stage { get; set; }
            public Round round { get; set; }
            public string date { get; set; }
            public int id { get; set; }
        }

}
