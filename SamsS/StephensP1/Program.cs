using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace StephensP1
{
    class Program 
    {
        public static XmlSerializer basketSerializer = new XmlSerializer(typeof(List<Basketball>));
        public static XmlSerializer footSerializer = new XmlSerializer(typeof(List<Football>));
        public static XmlSerializer baseSerializer = new XmlSerializer(typeof(List<Baseball>));

        public static void Main(string[] args)
        {
            //Welcome banner for users when they open the app
            Console.WriteLine("\t   Welcome to the Sports App");
            Console.WriteLine("here you are able to find out a couple of facts about");
            Console.WriteLine("the 5 teams with most championships from the listed sports");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            
            //paths to each of our sports files
            string path0 = @".\Basketball.txt";
            string path1 = @".\Baseball.txt";
            string path2 = @".\Football.txt";

            List<Basketball> basketballTeams = new List<Basketball>();
            List<Football> fballTeams = new List<Football>();
            List<Baseball> baballTeams = new List<Baseball>();

            if(File.Exists(path0) && File.Exists(path1) && File.Exists(path2))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Basketball>));
                if (!File.Exists(path0))
                {
                    Console.WriteLine("File Not Found");
                    
                }
                else
                {
                    using StreamReader reader = new StreamReader(path0);
                    var record = (List<Basketball>)serializer.Deserialize(reader);
                    if (record is null)
                    {
                        throw new InvalidDataException();
                    
                    }
                    else
                    {
                        basketballTeams = record;
                    }
                }
                
               serializer = new XmlSerializer(typeof(List<Football>));
            if (!File.Exists(path2))
            {
                Console.WriteLine("File Not Found");
        
            }
            else
            {
                using StreamReader reader = new StreamReader(path2);
                var record = (List<Football>)serializer.Deserialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                   
                }
                else
                {
                    fballTeams = record;
                }
            }

            
             serializer = new XmlSerializer(typeof(List<Baseball>));
            if (!File.Exists(path1))
            {
                Console.WriteLine("File Not Found");
                
            }
            else
            {
                using StreamReader reader = new StreamReader(path1);
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
                

                // Basketball basketball = new Basketball();
                // basketball.ReloadRosters(path0);

                // Baseball baseball = new Baseball();
                // baseball.ReloadRosters(path1);

                // Football football = new Football();
                // football.ReloadRosters(path2);

                //change to have lists based on how you can do Football.list
                SportsMenu(basketballTeams, fballTeams, baballTeams);

                var stringWriter = new StringWriter();
                basketSerializer.Serialize(stringWriter, basketballTeams);

                stringWriter.Close();
                string text1 =  stringWriter.ToString();

                File.WriteAllText(path0, text1); 

                stringWriter = new StringWriter();
                baseSerializer.Serialize(stringWriter, baballTeams);

                stringWriter.Close();
                text1 =  stringWriter.ToString();

                File.WriteAllText(path1, text1);

                 stringWriter = new StringWriter();
                footSerializer.Serialize(stringWriter, fballTeams);

                stringWriter.Close();
                text1 =  stringWriter.ToString();

                File.WriteAllText(path2, text1);
       

                    //Serialize data and write to files
                    // basketball.SerializeData(path0);
                    // baseball.SerializeData(path1);
                    // football.SerializeData(path2);
            }
            else
            {

             //Football Team creations
                Football football = new Football("New England Patriots",1959,541,433, 6);
                Football steelers = new Football("Pittsburgh Steelers",1933, 671, 578, 6);
                Football packers = new Football("Green Bay Packers",1919, 799, 598, 13);
                Football bears = new Football("Chicago Bears",1920, 793, 634, 9);
                Football giants = new Football("New York Giants",1925, 721, 649, 8);

                //add all the teams to our football list
                football.AddNewTeam(football);
                football.AddNewTeam(steelers);
                football.AddNewTeam(packers);
                football.AddNewTeam(bears);
                football.AddNewTeam(giants);

                //Basketball Team creations
                Sport basketball = new Basketball("Los Angeles Lakers",1946, 3530, 2445, 17);
                Sport celtics = new Basketball("Boston Celtics",1946, 3609, 2474, 17);
                Sport spurs = new Basketball("San Antonio Spurs",1967, 2671, 1910, 5);
                Sport bulls = new Basketball("Chicago Bulls",1966, 2369, 2281, 6);
                Sport warriors = new Basketball("Golden State Warriors",1946, 2947, 3123, 7);

                //add all the teams to our basketball list
                basketballTeams.Add((Basketball)basketball);
                basketballTeams.Add((Basketball)celtics);
                basketballTeams.Add((Basketball)spurs);
                basketballTeams.Add((Basketball)bulls);
                basketballTeams.Add((Basketball)warriors);

                //Baseball Team creations
                Baseball baseball = new Baseball("New York Yankees", 1903, 10684, 8080, 27);
                Baseball cardinals = new Baseball("St Louis Cardinals",1882, 11202, 10323, 11);
                Baseball athletics = new Baseball("Oakland Athletics",1901, 9260, 9766, 9);
                Baseball sGiants = new Baseball("San Francisco Giants",1883, 11461, 9937, 8);
                Baseball redSox = new Baseball("Boston Red Sox",1901, 9874, 9182, 9);

                //add all the teams to our baseball list
                baseball.AddNewTeam(baseball);
                baseball.AddNewTeam(cardinals);
                baseball.AddNewTeam(athletics);
                baseball.AddNewTeam(sGiants);
                baseball.AddNewTeam(redSox);

                SportsMenu(basketballTeams, Football.footballTeams, Baseball.baseballTeams);
                // SportsMenu(basketballTeams, fballTeams, baballTeams);

                var stringWriter = new StringWriter();
                basketSerializer.Serialize(stringWriter, basketballTeams);

                stringWriter.Close();
                string text1 =  stringWriter.ToString();

                File.WriteAllText(path0, text1); 

                stringWriter = new StringWriter();
                baseSerializer.Serialize(stringWriter, Baseball.baseballTeams);

                stringWriter.Close();
                text1 =  stringWriter.ToString();

                File.WriteAllText(path1, text1); 

                stringWriter = new StringWriter();
                footSerializer.Serialize(stringWriter, Football.footballTeams);

                stringWriter.Close();
                text1 =  stringWriter.ToString();

                File.WriteAllText(path2, text1); 

               

            //Serialize data and write to files
            // basketball.SerializeData(path0);
            // baseball.SerializeData(path1);
            // football.SerializeData(path2);
            }
        }

        //Where the user selects which sport they want to interact with
        public static void SportsMenu(List<Basketball> bBall, List<Football> fBall, List<Baseball> baBall)
        {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Sport:");
                Console.WriteLine("1: Basketball");
                Console.WriteLine("2: Football");
                Console.WriteLine("3: Baseball");
                Console.WriteLine("0: Exit the program.");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        BasketballMenu(bBall);
                        break;

                    case "2":
                        FootballMenu(fBall[0]);
                        break;

                    case "3":
                        BaseballMenu(baBall[0]);
                        break;

                    case "0":
                        loop = false;
                        //Call serialize here while its exiting
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

         public static void BasketballMenu(List<Basketball> bBall) {
           
            bool loop = true;
            while(loop)
            {

                Console.WriteLine("Please select an Team:");
                //Console.WriteLine("1: Print Teams Information");
    
                for(int i = 0; i < bBall.Count; i++)
                {
                  Console.WriteLine(i+1 + ": " +  bBall[i].teamName);
                }

                Console.WriteLine("99: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu.");

                int choice = Int32.Parse(Console.ReadLine()); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case >0 and < 99:// if (choice == "1")
                        bBall[choice-1].DisplayTeamInfo(5);
                        break;

                    case 99:
                        BasketballWinComparisonMenu(bBall);
                        break;

                    case 0:
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

         public static void FootballMenu(Football fball) {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: New England Patriots");
                //Console.WriteLine("1: Print Teams Information");
                Console.WriteLine("2: Pittsburgh Steelers");
                Console.WriteLine("3: Green Bay Packers");
                Console.WriteLine("4: Chicago Bears");
                Console.WriteLine("5: New York Giants");
                Console.WriteLine("6: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        fball.DisplayTeamInfo(0);
                        break;

                    //  case "1": // if (choice == "1")
                    //     Sport.ReadFile(path);
                    //     break;

                    case "2":
                        fball.DisplayTeamInfo(1);
                        break;

                    case "3":
                        fball.DisplayTeamInfo(2);
                        break;

                     case "4":
                        fball.DisplayTeamInfo(3);
                        break;

                    case "5":
                        fball.DisplayTeamInfo(4);
                        break;

                    case "6":
                        FootballWinComparisonMenu(fball);
                        break;

                    case "0":
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

         public static void BaseballMenu(Baseball baBall) {
            bool loop = true;

           
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: New York Yankees");
                //Console.WriteLine("1: Print Teams Information");
                Console.WriteLine("2: St Louis Cardinals");
                Console.WriteLine("3: Oakland Athletics");
                Console.WriteLine("4: San Francisco Giants");
                Console.WriteLine("5: Boston Red Sox");
                Console.WriteLine("6: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        baBall.DisplayTeamInfo(0);
                        break;

                    //  case "1": // if (choice == "1")
                    //     Sport.ReadFile(path);
                    //     break;

                    case "2":
                        baBall.DisplayTeamInfo(1);
                        break;

                    case "3":
                        baBall.DisplayTeamInfo(2);
                        break;

                     case "4":
                        baBall.DisplayTeamInfo(3);
                        break;

                    case "5":
                        baBall.DisplayTeamInfo(4);
                        break;

                    case "6":
                    //for this and football do like list item 0 because that is a single instance which will allow them to still work like that
                        BaseballWinComparisonMenu(baBall);
                        break;

                    case "0":
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

        public static void FootballWinComparisonMenu(Football fBall) {
                bool loop = true;
            while(loop)
            {
                Console.WriteLine(@"1 - New England Patriots 2 - Pittsburgh Steelers 3 - Green Bay Packers
4 - Chicago Bears 5 - New York Giants");

                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("4: Compare Team 1 and 5");
                Console.WriteLine("5: Compare Team 2 and 3");
                Console.WriteLine("6: Compare Team 2 and 4");
                Console.WriteLine("7: Compare Team 2 and 5");
                Console.WriteLine("8: Compare Team 3 and 4");
                Console.WriteLine("9: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Football Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        fBall.CompareWins(0, 1);
                        break;

                    case "2":
                        fBall.CompareWins(0, 2);
                        break;

                    case "3":
                        fBall.CompareWins(0, 3);
                        break;

                     case "4":
                        fBall.CompareWins(0, 4);
                        break;

                    case "5":
                        fBall.CompareWins(1, 2);
                        break;

                    case "6":
                        fBall.CompareWins(1, 3);
                        break;

                    case "7":
                        fBall.CompareWins(1, 4);
                        break;

                    case "8":
                        fBall.CompareWins(2, 3);
                        break;

                    case "9":
                        fBall.CompareWins(2, 4);
                        break;

                    case "10":
                        fBall.CompareWins(3, 4);
                        break;

                    case "0":
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

        //don't know if it will look pretty but don't even call compare just put the logic under
        //and then maybe add a comment in the code and possibly mention it in your presentation
        public static void BasketballWinComparisonMenu(List<Basketball> bBall) {
                bool loop = true;
            while(loop)
            {
                Console.WriteLine(@"1 - Los Angeles Lakers 2 - Boston Celtics 3 - San Antonio Spurs
4 - Chicago Bulls 5 - Golden State Warriors ");
                
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("4: Compare Team 1 and 5");
                Console.WriteLine("5: Compare Team 2 and 3");
                Console.WriteLine("6: Compare Team 2 and 4");
                Console.WriteLine("7: Compare Team 2 and 5");
                Console.WriteLine("8: Compare Team 3 and 4");
                Console.WriteLine("9: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Basketball Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                   case "1": // if (choice == "1")
                        Basketball.CompareBasketballWins(bBall[0], bBall[1]);
                        break;

                    case "2":
                        Basketball.CompareBasketballWins(bBall[0], bBall[2]);
                        break;

                    case "3":
                        Basketball.CompareBasketballWins(bBall[0], bBall[3]);
                        break;

                     case "4":
                         Basketball.CompareBasketballWins(bBall[0], bBall[4]);
                        break;

                    case "5":
                         Basketball.CompareBasketballWins(bBall[1], bBall[2]);
                        break;

                    case "6":
                         Basketball.CompareBasketballWins(bBall[1], bBall[3]);
                        break;

                    case "7":
                         Basketball.CompareBasketballWins(bBall[1], bBall[4]);
                        break;

                    case "8":
                        Basketball.CompareBasketballWins(bBall[2], bBall[3]);
                        break;

                    case "9":
                        Basketball.CompareBasketballWins(bBall[2], bBall[4]);
                        break;

                    case "10":
                        Basketball.CompareBasketballWins(bBall[3], bBall[4]);
                        break;

                    case "0":
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }

        public static void BaseballWinComparisonMenu(Baseball baBall) {
            bool loop = true;
            while(loop)
            {
              Console.WriteLine(@"1 - New York Yankees 2 - St Louis Cardinals 3 - Oakland Athletics
4 - San Francisco Giants 5 - Boston Red Sox");

                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("4: Compare Team 1 and 5");
                Console.WriteLine("5: Compare Team 2 and 3");
                Console.WriteLine("6: Compare Team 2 and 4");
                Console.WriteLine("7: Compare Team 2 and 5");
                Console.WriteLine("8: Compare Team 3 and 4");
                Console.WriteLine("9: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Baseball Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        baBall.CompareWins(0, 1);
                        break;

                    case "2":
                        baBall.CompareWins(0, 2);
                        break;

                    case "3":
                        baBall.CompareWins(0, 3);
                        break;

                     case "4":
                        baBall.CompareWins(0, 4);
                        break;

                    case "5":
                        baBall.CompareWins(1, 2);
                        break;

                    case "6":
                        baBall.CompareWins(1, 3);
                        break;

                    case "7":
                        baBall.CompareWins(1, 4);
                        break;

                    case "8":
                        baBall.CompareWins(2, 3);
                        break;

                    case "9":
                        baBall.CompareWins(2, 4);
                        break;

                    case "10":
                        baBall.CompareWins(3, 4);
                        break;

                    case "0":
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please Enter one of the options!");
                        break;
                }
            }
        }
    }

}
