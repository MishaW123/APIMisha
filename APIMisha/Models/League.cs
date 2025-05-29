namespace APIMisha.Models
{

    public class Leagues
    {
        public List<League> leagues { get; set; }
    }

    public class League
    {
        public string idLeague { get; set; }
        public string strLeague { get; set; }
        public string strSport { get; set; }
    }
}
