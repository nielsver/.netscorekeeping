using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectm
{
    internal class Teams
    {
        string _name;
        int _wins;
        int _losses;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }
        public int Losses
        {
            get { return _losses; }
            set { _losses = value; }
        }
        public int Points
        {
            get { return Wins * 3 + Losses; }

        }
        public int Games
        {
            get { return Wins + Losses; }

        }
    }
}
