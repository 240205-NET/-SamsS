using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 
{
    
    public class Baseball : Sport 
    {
        
        public int worldSeriesTitles;
        public static List<Baseball> baseballTeams = new List<Baseball>();
        public Baseball(){}

        public Baseball(string teamName, int foundingYear, int teamWins, int teamLoses, int worldSeriesTitles) 
        {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.worldSeriesTitles = worldSeriesTitles;
        }
                                              
       public override void AddNewTeam(Sport newTeam) 
       {
            baseballTeams.Add((Baseball)newTeam);
       }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
             result.AppendLine($"Name: {this.teamName} \n Founding Year: {this.foundingYear} \n Wins: {this.teamWins} \n Loses: {this.teamLoses} \n NBAChampionships: {this.worldSeriesTitles}");
            return result.ToString();

            
        }

        public override void DisplayTeamInfo(int team) 
        {
            Console.WriteLine($"Name: {baseballTeams[team].teamName} \nFounding Year: {baseballTeams[team].foundingYear} \nTeam Record: {baseballTeams[team].teamWins}-{baseballTeams[team].teamLoses}");
            Console.WriteLine($"WorldSeriesTitles: {baseballTeams[team].worldSeriesTitles}");
        }
        
        // Method to show which of the two past in baseball teams has the most wins
        public override void CompareWins(int teamA, int teamB) 
        {
            if(baseballTeams[teamA].teamWins > baseballTeams[teamB].teamWins) 
            {
                Console.WriteLine(baseballTeams[teamA].teamName + " has more wins in total than " + baseballTeams[teamB].teamName);
            }
            else if(baseballTeams[teamA].teamWins == baseballTeams[teamB].teamWins) 
            {
                Console.WriteLine(baseballTeams[teamA].teamName + " and " + baseballTeams[teamB].teamName + " have won the same amount of games");
            }
            else 
            {
                Console.WriteLine(baseballTeams[teamB].teamName + " has more wins in total than " + baseballTeams[teamA].teamName);
            }

        }
    }
}
