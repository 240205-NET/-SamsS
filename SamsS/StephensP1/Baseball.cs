using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {
    
    public class Baseball : Sport {
        
        public int worldSeriesTitles;
        public static List<Baseball> baseballTeams = new List<Baseball>();
        private XmlSerializer baseSerializer = new XmlSerializer(typeof(Baseball));

        public Baseball(){}

        public Baseball(string teamName, int foundingYear, int teamWins, int teamLoses, int worldSeriesTitles) {
            this.teamName = teamName;
            this.foundingYear = foundingYear;
            this.teamWins = teamWins;
            this.teamLoses = teamLoses;
            this.worldSeriesTitles = worldSeriesTitles;
        }
                                              
    //    public List<Baseball> returnBaseballTeams() {
    //        return baseballTeams;
    //    }

       public override void AddNewTeam(Sport newTeam) {
               baseballTeams.Add((Baseball)newTeam);
            //    Serialize((Baseball)newTeam, path);
            //    WriteFile(newTeam, path);
               
        }

        // public override void ReloadRosters(string returningTeams) {
        //       baseballTeams = DeserializeXML(returningTeams);
        // }

         

        public string SerializeXML()
        {
            var stringWriter = new StringWriter();
            baseSerializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
             result.AppendLine($"Name: {this.teamName} \n Founding Year: {this.foundingYear} \n Wins: {this.teamWins} \n Loses: {this.teamLoses} \n NBAChampionships: {this.worldSeriesTitles}");
            return result.ToString();

            
        }

        public static void Serialize(string path)
        {
            // convert/serialize the object
            // Console.WriteLine(currTeam.SerializeXML());

            // save the serialized object to a file
            // string[] text1 = {currTeam.SerializeXML()};
            List<String> text1 = new List<String>();
            foreach(Baseball ba in baseballTeams) {
                text1.Add(ba.SerializeXML());
            }
            // File.WriteAllLines(path, text1);

            //write the serialized object to the file
            if( File.Exists(path))
            {
                File.AppendAllLines(path,text1);
            }
            else
            {
                File.WriteAllLines(path, text1); 
            }
        }

       static List<Baseball> DeserializeXML(string path)
        {
            List<Baseball> baballTeams = new List<Baseball>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Baseball>));
            if (!File.Exists(path))
            {
                Console.WriteLine("File Not Found");
                return null;
            }
            else
            {
                using StreamReader reader = new StreamReader(path);
                var record = (List<Baseball>)serializer.Deserialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                   
                }
                else
                {
                    baballTeams = record;
                }
            }
            return baballTeams;
        }

        // public override void SerializeData(string path) {
        //     Serialize(path);
        // }

        public override void DisplayTeamInfo(int team) {
            Console.WriteLine($"Name: {baseballTeams[team].teamName} \nFounding Year: {baseballTeams[team].foundingYear} \nTeam Record: {baseballTeams[team].teamWins}-{baseballTeams[team].teamLoses}");
            Console.WriteLine($"WorldSeriesTitles: {baseballTeams[team].worldSeriesTitles}");
        }
        
        // Method to show which of the two past in baseball teams has the most wins
        public override void CompareWins(int teamA, int teamB) {
            if(baseballTeams[teamA].teamWins > baseballTeams[teamB].teamWins) {
                Console.WriteLine(baseballTeams[teamA].teamName + " has more wins in total than " + baseballTeams[teamB].teamName);
            }
            else if(baseballTeams[teamA].teamWins == baseballTeams[teamB].teamWins) {
                Console.WriteLine(baseballTeams[teamA].teamName + " and " + baseballTeams[teamB].teamName + " have won the same amount of games");
           }
            else {
                Console.WriteLine(baseballTeams[teamB].teamName + " has more wins in total than " + baseballTeams[teamA].teamName);
            }

        }
    }
}
