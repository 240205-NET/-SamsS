using System;
using System.IO;
using System.Xml.Serialization;

namespace StephensP1 {
    
    public abstract class Sport {
        
        public string? teamName {set; get;}
        public int foundingYear;
        public int teamWins {set; get;}
        public int teamLoses{set; get;}

        // public abstract void DisplayChampionshipWins();

        // public abstract void DisplayWinLossRecord();

        public abstract void CompareWins(int teamA, int teamB);

        public abstract void AddNewTeam(Sport newTeam);

        // public abstract void ReloadRosters(string returningTeams);

        public abstract void DisplayTeamInfo(int team);


           

        //  protected static void WriteFile(Sport currSport, string path)
        // {
        //     // display/confirm the object
        //     // Console.WriteLine(currSport.ToString());

        //     // save to a file as text
        //     string[] text = {currSport.ToString()};

        //     if( File.Exists(path))
        //     {
        //         File.AppendAllLines(path,text);
        //     }
        //     else
        //     {
        //         File.WriteAllLines(path, text); 
        //     }
        // }

        //based on what he says, change this back to just accepting path and change it back to for each that 
        //prints everything in the file at the specified path like in the example
        public static void ReadFile(string path, string currTeam)
        {
            // read from the file
            if(File.Exists(path))
            {
                string[] readText = File.ReadAllLines(path);

                for(int s = 0; s < readText.Length; s++) 
                {
                    if(readText[s] == currTeam) {
                        Console.WriteLine(readText[s]);
                    }
                    
                }

                // foreach (string s in readText)
                // {
                //     Console.WriteLine(s);
                // }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
