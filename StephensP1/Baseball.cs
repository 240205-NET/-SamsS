using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {
    
    class Baseball : Sport {
        
        public int worldSeriesTitles;
        //private List<Baseball> baseballTeams = new List<Baseball>();

        public Baseball(string teamName, int foundingYear, int teamWins, int teamLoses, int worldSeriesTitles) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.worldSeriesTitles = worldSeriesTitles;
        }
                                              

        // public override void AddNewTeam(Sport newTeam) {

        //     baseballTeams.Add((Baseball)newTeam);
        // }

        // static void Serialize(Sport Lawrence, string path)
        // {
        //     // convert/serialize the object
        //     Console.WriteLine((Baseball)Lawrence.SerializeXML());

        //     // save the serialized object to a file
        //     string[] text1 = {(Baseball)Lawrence.SerializeXML()};
        //     File.WriteAllLines(path, text1);
        // }
        
        // Method to show which of the two past in baseball teams has the most wins
        public override void CompareWins(int teamA, int teamB) {
            //if(baseballTeams[teamA].teamWins > baseballTeams[teamB].teamWins) {
                //Console.WriteLine(baseballTeams[teamA].teamName + " has more wins in total than " + baseballTeams[teamB].teamName);
            //}
            //else if(baseballTeams[teamA].teamWins == baseballTeams[teamB].teamWins) {
                ////Console.WriteLine(baseballTeams[teamA].teamName + " and " + baseballTeams[teamB].teamName + " have won the same amount of games");
           // }
            //else {
                ////Console.WriteLine(baseballTeams[teamB].teamName + " has more wins in total than " + baseballTeams[teamA].teamName);
            //}

        }
    }
}
