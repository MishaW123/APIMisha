namespace APIMisha.Models
{

    public class Stats
    {
        public List<Stat> events { get; set; }
    }
    public class Stat
    {
        public string strEvent { get; set; }
        public string strFilename { get; set; }
        public string strLeague { get; set; }
        public string intHomeScore { get; set; }
        public string intAwayScore { get; set; }
        public string dateEvent { get; set; }
        public string strTime { get; set; }
        public string strCountry { get; set; }
    }
}
