using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectm
{
    internal class TeamView
    {
        private ObservableCollection<Teams> teams = new ObservableCollection<Teams>
        {
            new Teams { Name = "Team A", Wins = 5, Losses = 3},
            new Teams { Name = "Team B", Wins = 7, Losses = 1 },
            new Teams { Name = "Team C", Wins = 3, Losses = 5},
            new Teams { Name = "Team D", Wins = 8, Losses = 0}
        };

        public ObservableCollection<Teams> Teams
        {
            get { return teams; }
            set
            {
                if (teams != value)
                {
                    teams = value;

                }
            }
        }
    }
}
