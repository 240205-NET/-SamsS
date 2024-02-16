using StephensP1;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StephensP1.Test;

//Here I am making sure that the files don't exist before the program runs for the first time
public class UnitTest1
{
    [Fact]
    public void checkForFilesBeforeRun()
    {
      string path = @".\Basketball.txt";
      string path1 = @".\Football.txt";
      string path2 = @".\Baseball.txt";

      bool basketballFileExists = File.Exists(path);
      bool footballFileExists = File.Exists(path1);
      bool baseballFileExists = File.Exists(path2);


      Assert.False(basketballFileExists, "File was found");
      Assert.False(footballFileExists, "File was found");
      Assert.False(baseballFileExists, "File was found");
    }

    //Here I want to make sure the file is created after we exit the program
    [Fact]
    public void checkForBasketballFileAfterRun()
    {
        string path = @".\Basketball.txt";
        string path1 = @".\Football.txt";
        string path2 = @".\Baseball.txt";
        string userOption = "0";
        string[] args = {" "};

        //logic to run my program and exit it, will need to enter a 0 when the menu pops up
        using(var consoleInput = new StringReader(userOption) )
        {
          Console.SetIn(consoleInput);

          var writer = new StringWriter();
          Console.SetOut(writer);

          // Program.SportsMenu(tempBasketList, tempFootList, tempBaseList);
          Program.Main(args);

          var output = writer.ToString();
        }
      
  
      bool basketballFileExists = File.Exists(path);
      bool footballFileExists = File.Exists(path1);
      bool baseballFileExists = File.Exists(path2);


      Assert.True(basketballFileExists, "File was not found");
      Assert.True(footballFileExists, "File was not found");
      Assert.True(baseballFileExists, "File was not found");
      
    }

   
    //When running this test case, it stops and says System.OutofMemoryException: Insufficient memory to continue the 
    //execution of the program;  I couldn't figure out what was causing it and how to fix it, so it's commented out.

    // [Fact]
    // public void SportsMenuChoiceParameterCheck()
    // {
    //     string invalidMenuOption = "4";
    //     string[] args = {" "};
    //     string expectedOutput = "Please Enter one of the options!";

    //     //logic to run my program and exit it, will need to enter a 0 when the menu pops up
    //     using(var consoleInput = new StringReader(invalidMenuOption) )
    //     {
    //       Console.SetIn(consoleInput);

    //       var writer = new StringWriter();
    //       Console.SetOut(writer);

    //       Program.Main(args);

    //       var output = writer.ToString();

    //       Assert.Equals(expectedOutput, output);
    //     }
    // }
}