using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {

     class Basketball : Sport {

        public int nbaChampionships;
        //private List<Basketball> basketballTeams = new List<Basketball>();

        public Basketball(string teamName, int foundingYear, int teamWins, int teamLoses, int nbaChampionships) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.nbaChampionships = nbaChampionships;
        }


       
        // public override void AddNewTeam(Sport newTeam) {
        //      basketballTeams.Add((Basketball)newTeam);
        // }

        // static void Serialize(Sport Lawrence, string path)
        // {
        //     // convert/serialize the object
        //     Console.WriteLine((Basketball)Lawrence.SerializeXML());

        //     // save the serialized object to a file
        //     string[] text1 = {(Basketball)Lawrence.SerializeXML()};
        //     File.WriteAllLines(path, text1);
        // }


        // Method to show which of the two past in basketball teams has the most wins
        public override void CompareWins(int teamA, int teamB) {
            //if(basketballTeams[teamA].teamWins > basketballTeams[teamB].teamWins) {
                //Console.WriteLine(basketballTeams[teamA].teamName + " has more wins in total than " + basketballTeams[teamB].teamName);
            //}
            //else if(basketballTeams[teamA].teamWins == basketballTeams[teamB].teamWins) {
                ////Console.WriteLine(basketballTeams[teamA].teamName + " and " + basketballTeams[teamB].teamName + " have won the same amount of games");
           // }
            //else {
                ////Console.WriteLine(basketballTeams[teamB].teamName + " has more wins in total than " + basketballTeams[teamA].teamName);
            //}

        }
        
    }
    
}
