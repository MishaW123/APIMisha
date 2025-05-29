

using Newtonsoft.Json;

namespace APIMisha.Models
{
    public class Events
    {
        [JsonProperty("event")]
        public List<Event> events { get; set; }
    }

    public class Event
    {
        public string idEvent { get; set; }
        public string strEvent { get; set; }
        public string strSport { get; set; }
        public string idLeague { get; set; }
        public string strLeague { get; set; }
        public string strSeason { get; set; }
        public string strDescriptionEN { get; set; }
        public string strHomeTeam { get; set; }
        public string intHomeScore { get; set; }
        public string intRound { get; set; }
        public string intAwayScore { get; set; }
        public string dateEvent { get; set; }
        public string strTime { get; set; }
        public string strGroup { get; set; }
        public string idVenue { get; set; }
        public string strVenue { get; set; }
        public string strCountry { get; set; }
        public string strStatus { get; set; }
    }
}
