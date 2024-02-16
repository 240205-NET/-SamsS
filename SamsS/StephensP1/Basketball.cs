using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 
{

     public class Basketball : Sport 
     {

        public int nbaChampionships;
        public Basketball(){}

        public Basketball(string teamName, int foundingYear, int teamWins, int teamLoses, int nbaChampionships) 
        {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.nbaChampionships = nbaChampionships;
        }

       //exists just to satisfy abstract/override from Sport
       public override void AddNewTeam(Sport newTeam) 
       {
              
       }

       public override string ToString()
       {
            var result = new System.Text.StringBuilder();
            result.AppendLine($"Name: {this.teamName} \n Founding Year: {this.foundingYear} \n Wins: {this.teamWins} \n Loses: {this.teamLoses} \n Championships: {this.nbaChampionships}");
            return result.ToString();
       }

        public override void DisplayTeamInfo(int i) 
        {
            Console.WriteLine($"Name: {this.teamName} \nFounding Year: {this.foundingYear} \nTeam Record: {this.teamWins}-{this.teamLoses}");
            Console.WriteLine($"NBAChampionships: {this.nbaChampionships}");
        
        }

        //exists just to satisfy abstract/override from Sport
        public override void CompareWins(int teamB, int unusedNumber) 
        {
        

        }

        public static void CompareBasketballWins(Basketball teamA, Basketball teamB) 
        {
            if(teamA.teamWins > teamB.teamWins) 
            {
                Console.WriteLine(teamA.teamName + " has more wins in total than " + teamB.teamName);
            }
            else if(teamA.teamWins == teamB.teamWins) 
            {
                Console.WriteLine(teamA.teamName + " and " + teamB.teamName  + " have won the same amount of games");
            }
            else 
            {
                Console.WriteLine(teamB.teamName + " has more wins in total than " + teamA.teamName);
            }

            //for formatting
            Console.WriteLine();
        }
        
    }
    
}
