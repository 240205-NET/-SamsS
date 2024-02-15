using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {

     class Football : Sport {

        public int superBowls;
        //private List<Football> footballTeams = new List<Football>();

        public Football(string teamName, int foundingYear, int teamWins, int teamLoses, int superBowls) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.superBowls = superBowls;
        }

        

        //  public override void AddNewTeam(Sport newTeam) {

        //     footballTeams.Add((Football)newTeam);
        // }

        // static void Serialize(Sport Lawrence, string path)
        // {
        //     // convert/serialize the object
        //     Console.WriteLine((Football)Lawrence.SerializeXML());

        //     // save the serialized object to a file
        //     string[] text1 = {(Football)Lawrence.SerializeXML()};
        //     File.WriteAllLines(path, text1);
        // }
        
        // Method to show which of the two past in football teams has the most wins
        public override void CompareWins(int teamA, int teamB) {
            //if(footballTeams[teamA].teamWins > footballTeams[teamB].teamWins) {
                //Console.WriteLine(footballTeams[teamA].teamName + " has more wins in total than " + footballTeams[teamB].teamName);
            //}
            //else if(footballTeams[teamA].teamWins == footballTeams[teamB].teamWins) {
                ////Console.WriteLine(footballTeams[teamA].teamName + " and " + footballTeams[teamB].teamName + " have won the same amount of games");
           // }
            //else {
                ////Console.WriteLine(footballTeams[teamB].teamName + " has more wins in total than " + footballTeams[teamA].teamName);
            //}

        }
        
    }
    
}
