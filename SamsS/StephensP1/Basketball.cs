using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {

     public class Basketball : Sport {

        public int nbaChampionships;
        
        //if this doesn't work/doesn't populate, you might need to rework this and the other respective sports one's
        //to be in the constructor like in our practice from 2/12
        //protected static List<Basketball> basketballTeams = new List<Basketball>();
        // private XmlSerializer basketSerializer = new XmlSerializer(typeof(Basketball));

        public Basketball(){}

        public Basketball(string teamName, int foundingYear, int teamWins, int teamLoses, int nbaChampionships) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.nbaChampionships = nbaChampionships;
        }


       
       public override void AddNewTeam(Sport newTeam) {
            
             //  basketballTeams.Add((Basketball)newTeam);
            //    Serialize(path);
            //    WriteFile(newTeam, path);
          
        }

        //  public override void ReloadRosters(string returningTeams) {
        // //     basketballTeams = DeserializeXML(returningTeams);
        // }

       
        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
             result.AppendLine($"Name: {this.teamName} \n Founding Year: {this.foundingYear} \n Wins: {this.teamWins} \n Loses: {this.teamLoses} \n Championships: {this.nbaChampionships}");
            return result.ToString();

            
        }

       

        static List<Basketball> DeserializeXML(string path)
        {
            List<Basketball> bballTeams = new List<Basketball>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Basketball>));
            if (!File.Exists(path))
            {
                Console.WriteLine("File Not Found");
                return null;
            }
            else
            {
                using StreamReader reader = new StreamReader(path);
                var record = (List<Basketball>)serializer.Deserialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                   
                }
                else
                {
                    bballTeams = record;
                }
            }
            return bballTeams;
        }

        // public override void SerializeData(string path) {
        //     Serialize(path);
        // }

        public override void DisplayTeamInfo(int i) {
            Console.WriteLine($"Name: {this.teamName} \nFounding Year: {this.foundingYear} \nTeam Record: {this.teamWins}-{this.teamLoses}");
            Console.WriteLine($"NBAChampionships: {this.nbaChampionships}");
        
        }


        // Method to show which of the two past in basketball teams has the most wins
        public override void CompareWins(int teamB, int unusedNumber) {
            
        //     if(this.teamWins > teamB) {
        //         Console.WriteLine(this.teamName + " has more wins in total than ");
        //     }
        //     else if(this.teamWins == teamB) {
        //         Console.WriteLine(this.teamName + " and " +  " have won the same amount of games");
        //    }
        //     else {
        //         Console.WriteLine( " has more wins in total than " + this.teamName);
        //     }
       

        }

        public static void CompareBasketballWins(Basketball teamA, Basketball teamB) {
            if(teamA.teamWins > teamB.teamWins) {
                Console.WriteLine(teamA.teamName + " has more wins in total than " + teamB.teamName);
            }
            else if(teamA.teamWins == teamB.teamWins) {
                Console.WriteLine(teamA.teamName + " and " + teamB.teamName  + " have won the same amount of games");
           }
            else {
                Console.WriteLine(teamB.teamName + " has more wins in total than " + teamA.teamName);
            }

            //for formatting
            Console.WriteLine();
        }
        
    }
    
}
