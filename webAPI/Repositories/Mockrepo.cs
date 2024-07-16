using webAPI.Models;

namespace webAPI.Repositories
{
    public class MockRepo
    {
        List<Team> Teamslist = new List<Team>();

        public MockRepo()
        {
            Teamslist.Add(new Team() { id = 0, Name = "Team A", Wins = 5, Losses = 3});
            Teamslist.Add(new Team() { id = 1,Name = "Team B", Wins = 7, Losses = 1 });
            Teamslist.Add(new Team() { id = 2, Name = "Team C", Wins = 3, Losses = 5});
            Teamslist.Add(new Team() { id = 3, Name = "Team D", Wins = 8, Losses = 0});
        }

        public IEnumerable<Team> GetAllTeams() {
            return Teamslist;
        }

        public Team GetTeamById(int id) {
            Team _team = Teamslist.FirstOrDefault<Team>(t => t.id == id);
            return _team;
        }
    }
}