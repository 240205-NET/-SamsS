using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {

     public class Football : Sport {

        public int superBowls;
        public static List<Football> footballTeams = new List<Football>();
        private XmlSerializer footballSerializer = new XmlSerializer(typeof(Football));

        public Football(){}

        public Football(string teamName, int foundingYear, int teamWins, int teamLoses, int superBowls) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.superBowls = superBowls;
        }

        // public List<Football> returnFootballTeams() {
        //     return footballTeams;
        // }

        public override void AddNewTeam(Sport newTeam) {
               footballTeams.Add((Football)newTeam);
            //    Serialize((Football)newTeam, path);
            //    WriteFile(newTeam, path);
           
        }



        //  public override void ReloadRosters(string returningTeams) {
        // //         footballTeams = DeserializeXML(returningTeams);
        // }

         public override string ToString()
        {
            var result = new System.Text.StringBuilder();
             result.AppendLine($"Name: {this.teamName} \n Founding Year: {this.foundingYear} \n Wins: {this.teamWins} \n Loses: {this.teamLoses} \n NBAChampionships: {this.superBowls}");
            return result.ToString();

            
        }

        public string SerializeXML()
        {
            var stringWriter = new StringWriter();
            footballSerializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();
        }

        public static void Serialize(string path)
        {
            // convert/serialize the object
            // Console.WriteLine(currTeam.SerializeXML());

            // save the serialized object to a file
            // string[] text1 = {currTeam.SerializeXML()};
            List<String> text1 = new List<String>();
            foreach(Football f in footballTeams) {
                text1.Add(f.SerializeXML());
            }
            // File.WriteAllLines(path, text1);

            //writes serialized object to a file
            if( File.Exists(path))
            {
                File.AppendAllLines(path,text1);
            }
            else
            {
                File.WriteAllLines(path, text1); 
            }
        }

        // static List<Football> DeserializeXML(string path)
        // {
            
        //     return fballTeams;
        // }

        // public override void SerializeData(string path) {
        //     Serialize(path);
        // }

        public override void DisplayTeamInfo(int team) {
            Console.WriteLine($"Name: {footballTeams[team].teamName} \nFounding Year: {footballTeams[team].foundingYear}");
            Console.WriteLine($"Team Record: {footballTeams[team].teamWins}-{footballTeams[team].teamLoses} \nSuperbowls: {footballTeams[team].superBowls}");
        
        }
        
        // Method to show which of the two past in football teams has the most wins
        public override void CompareWins(int teamA, int teamB) {
            if(footballTeams[teamA].teamWins > footballTeams[teamB].teamWins) {
                Console.WriteLine(footballTeams[teamA].teamName + " has more wins in total than " + footballTeams[teamB].teamName);
            }
            else if(footballTeams[teamA].teamWins == footballTeams[teamB].teamWins) {
                Console.WriteLine(footballTeams[teamA].teamName + " and " + footballTeams[teamB].teamName + " have won the same amount of games");
           }
            else {
                Console.WriteLine(footballTeams[teamB].teamName + " has more wins in total than " + footballTeams[teamA].teamName);
            }

        }
        
    }
    
}
