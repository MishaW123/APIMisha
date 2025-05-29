namespace APIMisha.Models
{
    public class Teams
    {
        public List<Team> teams { get; set; }
    }
    public class Team
    {
        public string idTeam { get; set; }
        public string strTeam { get; set; }
        public string strTeamAlternate { get; set; }
        public string strTeamShort { get; set; }
        public string intFormedYear { get; set; }
        public string strSport { get; set; }
        public string strLeague { get; set; }
        public string strLeague2 { get; set; }
        public string strLeague3 { get; set; }
        public string strStadium { get; set; }
        public string strKeywords { get; set; }
        public string strLocation { get; set; }
        public string strWebsite { get; set; }
        public string strDescriptionEN { get; set; }
        public string strDescriptionRU { get; set; }
    }

}
