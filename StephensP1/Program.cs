using System;
using System.Runtime.CompilerServices;

namespace StephensP1 {

    class Program {

        public static void Main(string[] args)
        {
            //Welcome banner for users when they open the app
            Console.WriteLine("\t   Welcome to the Sports App");
            Console.WriteLine("here you are able to find out a couple of facts about");
            Console.WriteLine("the 5 teams with most championships from the listed sports");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            SportsMenu();

            //Football Team creations
            //Sport patriots = new Football("New England Patriots",1959,541,433, 6);
            //Sport steelers = new Football(Pittsburgh Steelers,1933, 671, 578, 6);
            //Sport packers = new Football(Green Bay Packers,1919, 799, 598, 13);
            //Sport bears = new Football(Chicago Bears,1920, 793, 634, 9);
            //Sport giants = new Football(New York Giants,1925, 721, 649, 8);

            //add all the teams to our football list
            //patriots.AddNewTeam(patriots);
            //patriots.AddNewTeam(steelers);
            //patriots.AddNewTeam(packers);
            //patriots.AddNewTeam(bears);
            //patriots.AddNewTeam(giants);

            //Basketball Team creations
            //Sport lakers = new Basketball(Los Angeles Lakers,1946, 3530, 2445, 17);
            //Sport celtics = new Basketball(Boston Celtics,1946, 3609, 2474, 17);
            //Sport spurs = new Basketball(San Antonio Spurs,1967, 2671, 1910, 5);
            //Sport bulls = new Basketball(Chicago Bulls,1966, 2369, 2281, 6);
            //Sport warriors = new Basketball(Golden State Warriors,1946, 2947, 3123, 7);

            //add all the teams to our basketball list
            //patriots.AddNewTeam(lakers);
            //patriots.AddNewTeam(celtics);
            //patriots.AddNewTeam(spurs);
            //patriots.AddNewTeam(bulls);
            //patriots.AddNewTeam(warriors);

            //Baseball Team creations
            //Sport yankees = new Baseball(New York Yankees, 1903, 10684, 8080, 27);
            //Sport cardinals = new Baseball(St Louis Cardinals,1882, 11202, 10323, 11);
            //Sport athletics = new Baseball(Oakland Athletics,1901, 9260, 9766, 9);
            //Sport sGiants = new Baseball(San Francisco Giants,1883, 11461, 9937, 8);
            //Sport redSox = new Baseball(Boston Red Sox,1901, 9874, 9182, 9);

            //add all the teams to our baseball list
            //patriots.AddNewTeam(yankees);
            //patriots.AddNewTeam(cardinals);
            //patriots.AddNewTeam(athletics);
            //patriots.AddNewTeam(sGiants);
            //patriots.AddNewTeam(redSox);


        }

        //Where the user selects which sport they want to interact with
        public static void SportsMenu() {
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
                        BasketballMenu();
                        break;

                    case "2":
                        FootballMenu();
                        break;

                    case "3":
                        BaseballMenu();
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

         public static void BasketballMenu() {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Los Angeles Lakers");
                Console.WriteLine("2: Boston Celtics");
                Console.WriteLine("3: Chicago Bulls");
                Console.WriteLine("4: Golden State Warriors");
                Console.WriteLine("5: San Antonio Spurs");
                Console.WriteLine("6: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu.");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        Console.WriteLine("Kobe to Shaq! Slam Dunk.");
                        break;

                    case "2":
                        Console.WriteLine("Bird. Mchale. Parrish");
                        break;

                    case "3":
                        Console.WriteLine("MJ. Pippen. Rodman.");
                        break;

                    case "4":
                        Console.WriteLine("Steph. Klay. Draymond.");
                        break;

                    case "5":
                        Console.WriteLine("Parker. Ginobli. Duncan.");
                        break;

                    case "6":
                        BasketballWinComparisonMenu();
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

         public static void FootballMenu() {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: New England Patriots");
                Console.WriteLine("2: Green Bay Packers");
                Console.WriteLine("3: Chicago Bears");
                Console.WriteLine("4: New York Giants");
                Console.WriteLine("5: Pittsburgh Steelers");
                Console.WriteLine("6: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        Console.WriteLine("Brady");
                        break;

                    case "2":
                        Console.WriteLine("Farve");
                        break;

                    case "3":
                        Console.WriteLine("Cutler");
                        break;

                     case "4":
                        Console.WriteLine("OBJ");
                        break;

                    case "5":
                        Console.WriteLine("Big Ben. AB. Bell");
                        break;

                    case "6":
                        FootballWinComparisonMenu();
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

         public static void BaseballMenu() {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: New York Yankees");
                Console.WriteLine("2: St. Louis Cardinals");
                Console.WriteLine("3: Boston Red Sox");
                Console.WriteLine("4: Oakland Athletics");
                Console.WriteLine("5: San Francisco Giants");
                Console.WriteLine("6: Compare Total Wins");
                Console.WriteLine("0: Return to Main Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        Console.WriteLine("Dimaggio");
                        break;

                    case "2":
                        Console.WriteLine("Pujoles");
                        break;

                    case "3":
                        Console.WriteLine("Ortiz");
                        break;

                     case "4":
                        Console.WriteLine("McGuire");
                        break;

                    case "5":
                        Console.WriteLine("Pence");
                        break;

                    case "6":
                        BaseballWinComparisonMenu();
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

        public static void FootballWinComparisonMenu() {
                bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("9: Compare Team 1 and 5");
                Console.WriteLine("4: Compare Team 2 and 3");
                Console.WriteLine("5: Compare Team 2 and 4");
                Console.WriteLine("6: Compare Team 2 and 5");
                Console.WriteLine("7: Compare Team 3 and 4");
                Console.WriteLine("8: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Football Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        //Patriots.CompareWins(0, 1)
                        break;

                    case "2":
                        //Patriots.CompareWins(0, 2)
                        break;

                    case "3":
                        //Patriots.CompareWins(0, 3)
                        break;

                     case "4":
                        //Patriots.CompareWins(0, 4)
                        break;

                    case "5":
                        //Patriots.CompareWins(1, 2)
                        break;

                    case "6":
                        //Patriots.CompareWins(1, 3)
                        break;

                    case "7":
                        //Patriots.CompareWins(1, 4)
                        break;

                    case "8":
                        //Patriots.CompareWins(2, 3)
                        break;

                    case "9":
                        //Patriots.CompareWins(2, 4)
                        break;

                    case "10":
                        //Patriots.CompareWins(3, 4)
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

        public static void BasketballWinComparisonMenu() {
                bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("9: Compare Team 1 and 5");
                Console.WriteLine("4: Compare Team 2 and 3");
                Console.WriteLine("5: Compare Team 2 and 4");
                Console.WriteLine("6: Compare Team 2 and 5");
                Console.WriteLine("7: Compare Team 3 and 4");
                Console.WriteLine("8: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Basketball Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                              case "1": // if (choice == "1")
                        //Patriots.CompareWins(0, 1)
                        break;

                    case "2":
                        //Patriots.CompareWins(0, 2)
                        break;

                    case "3":
                        //Patriots.CompareWins(0, 3)
                        break;

                     case "4":
                        //Patriots.CompareWins(0, 4)
                        break;

                    case "5":
                        //Patriots.CompareWins(1, 2)
                        break;

                    case "6":
                        //Patriots.CompareWins(1, 3)
                        break;

                    case "7":
                        //Patriots.CompareWins(1, 4)
                        break;

                    case "8":
                        //Patriots.CompareWins(2, 3)
                        break;

                    case "9":
                        //Patriots.CompareWins(2, 4)
                        break;

                    case "10":
                        //Patriots.CompareWins(3, 4)
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

        public static void BaseballWinComparisonMenu() {
                bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an Team:");
                Console.WriteLine("1: Compare Team 1 and 2");
                Console.WriteLine("2: Compare Team 1 and 3");
                Console.WriteLine("3: Compare Team 1 and 4");
                Console.WriteLine("9: Compare Team 1 and 5");
                Console.WriteLine("4: Compare Team 2 and 3");
                Console.WriteLine("5: Compare Team 2 and 4");
                Console.WriteLine("6: Compare Team 2 and 5");
                Console.WriteLine("7: Compare Team 3 and 4");
                Console.WriteLine("8: Compare Team 3 and 5");
                Console.WriteLine("10: Compare Team 4 and 5");
                Console.WriteLine("0: Return to Baseball Menu");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                //for formatting/making things look a little nicer
                Console.WriteLine();

                switch(choice)
                {
                              case "1": // if (choice == "1")
                        //Patriots.CompareWins(0, 1)
                        break;

                    case "2":
                        //Patriots.CompareWins(0, 2)
                        break;

                    case "3":
                        //Patriots.CompareWins(0, 3)
                        break;

                     case "4":
                        //Patriots.CompareWins(0, 4)
                        break;

                    case "5":
                        //Patriots.CompareWins(1, 2)
                        break;

                    case "6":
                        //Patriots.CompareWins(1, 3)
                        break;

                    case "7":
                        //Patriots.CompareWins(1, 4)
                        break;

                    case "8":
                        //Patriots.CompareWins(2, 3)
                        break;

                    case "9":
                        //Patriots.CompareWins(2, 4)
                        break;

                    case "10":
                        //Patriots.CompareWins(3, 4)
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
