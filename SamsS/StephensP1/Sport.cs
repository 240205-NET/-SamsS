using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1
{
    
    public abstract class Sport
    {
        
        public string? teamName {set; get;}
        public int foundingYear;
        public int teamWins {set; get;}
        public int teamLoses{set; get;}

        public abstract void CompareWins(int teamA, int teamB);
        public abstract void AddNewTeam(Sport newTeam);
        public abstract void DisplayTeamInfo(int team);
    }
}
