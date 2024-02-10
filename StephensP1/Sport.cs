namespace StephensP1 {
    
    abstract class Sport {
        
        public string? teamName {set; get;}
        public int foundingYear;
        public int teamWins {set; get;}
        public int teamLoses{set; get;}

        private List<Basketball> basketballTeams = new List<Basketball>();
        private List<Football> footballTeams = new List<Football>();

         private List<Baseball> baseballTeams = new List<Baseball>();

        // public abstract void DisplayChampionshipWins();

        // public abstract void DisplayWinLossRecord();

        public abstract void CompareWins(int teamA, int teamB);

        public virtual void AddNewTeam(Sport newTeam) {
            // string pathOne = @".\Football.txt";
            // string pathTwo = @".\Basketball.txt";
            // string pathThree = @".\Baseball.txt";

            if(newTeam.GetType() == typeof(Football)) {
               footballTeams.Add((Football)newTeam);
               //WriteFile(newTeam, pathOne);
            }
            else if(newTeam.GetType() == typeof(Basketball)) {
               basketballTeams.Add((Basketball)newTeam);
               //WriteFile(newTeam, pathTwo);
            }
            //(note) may need to make this another else if
            else {
               baseballTeams.Add((Baseball)newTeam);
               //WriteFile(newTeam, pathThree)
            }
        }

        //  static void WriteFile(Sport Lawrence, string path)
        // {
        //     // display/confirm the object
        //     Console.WriteLine(Lawrence.ToString());

        //     // save to a file as text
        //     Console.WriteLine("Writing to file...");
        //     string[] text = {Lawrence.ToString()};

        //     if( File.Exists(path))
        //     {
        //         File.AppendAllLines(path,text);
        //     }
        //     else
        //     {
        //         File.WriteAllLines(path, text); // WriteAllLines requires an IEnumerable (a collection) of strings
        //     // File.WriteLine(path, <string>); // WriteLine will operate on a single string
        //     }
        // }

        // static void ReadFile(string path)
        // {
        //     Console.WriteLine("Reading from file...");
        //     // read from the file
        //     if(File.Exists(path))
        //     {
        //         string[] readText = File.ReadAllLines(path);
        //         foreach (string s in readText)
        //         {
        //             Console.WriteLine(s);
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("File Not Found");
        //     }
        // }
    }
}
