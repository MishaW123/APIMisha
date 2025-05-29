using APIMisha.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIMisha.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        [ActionName("SearchCommand")]
        public async Task<Team> SearchCommand(string Name)
        {
            using(HttpClient client = new())
            {
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"searchteams.php?t={Name}");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                Teams teams = JsonConvert.DeserializeObject<Teams>(json);
                return teams.teams[0];
            }
        }
        [HttpGet]
        [ActionName("SearchEvents")]
        public async Task<List<Event>> SearchEvents(string Command1, string Command2)
        {
            using (HttpClient client = new())
            {
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"searchevents.php?e={Command1}_vs_{Command2}");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                Events Events = JsonConvert.DeserializeObject<Events>(json);
                if (Events != null)
                    return Events.events;
                else
                    return null;
            }
        }
        [HttpGet]
        [ActionName("AllLegues")]
        public async Task<List<League>> AllLegues()
        {
            using (HttpClient client = new())
            {
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"all_leagues.php");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                Leagues team = JsonConvert.DeserializeObject<Leagues>(json);
                
                var leagues = team.leagues.Where(league => league.strSport == "Soccer" && league.strLeague != "_No League").Take(20).ToList();
                return leagues;
            }
        }
        [HttpGet]
        [ActionName("LeagueTable")]
        public async Task<List<Table>> LeagueTable(int IDLeague, string season=null)
        {
            using (HttpClient client = new())
            {
                string s = season != null ? $"&s={season}" : "";
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"lookuptable.php?l={IDLeague}{s}");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                LeagueTable team = JsonConvert.DeserializeObject<LeagueTable>(json);
                return team.table;
            }
        }
        [HttpGet]
        [ActionName("EventStats")]
        public async Task<List<Stat>> EventStats(int IDEvent)
        {
            using (HttpClient client = new())
            {
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"lookupevent.php?id={IDEvent}");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                Stats team = JsonConvert.DeserializeObject<Stats>(json);
                return team.events;
            }
        }
        [HttpGet]
        [ActionName("PlayerInCommand")]
        public async Task<List<Player>> PlayerInCommand(int IDCommand)
        {
            using (HttpClient client = new())
            {
                HttpRequestMessage request = new(HttpMethod.Get, Links.URI + $"lookup_all_players.php?id={IDCommand}");
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                Players team = JsonConvert.DeserializeObject<Players>(json);
                return team.player;
            }
        }
    }
}
