namespace APIMisha.Models
{

    public class Players
    {
        public List<Player> player { get; set; }
    }

    public class Player
    {
        public string idPlayer { get; set; }
        public string idTeam { get; set; }
        public string strNationality { get; set; }
        public string strPlayer { get; set; }
        public string strPlayerAlternate { get; set; }
        public string strTeam { get; set; }
        public string strSport { get; set; }
        public string dateBorn { get; set; }
        public object dateDied { get; set; }
        public string strNumber { get; set; }
        public string strBirthLocation { get; set; }
        public string strStatus { get; set; }
        public string strDescriptionEN { get; set; }
        public string strPosition { get; set; }
        public string strHeight { get; set; }
        public string strWeight { get; set; }
    }
}
