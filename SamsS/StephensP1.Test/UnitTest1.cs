using StephensP1;
using System.IO;

namespace StephensP1.Test;

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
        List<Football> tempFootList = new List<Football>();
        List<Basketball> tempBasketList = new List<Basketball>();
        List<Baseball> tempBaseList = new List<Baseball>();

        //logic to run my program and exit it, will need to enter a 0 when the menu pops up

  
      bool basketballFileExists = File.Exists(path);
      bool footballFileExists = File.Exists(path1);
      bool baseballFileExists = File.Exists(path2);


      Assert.True(basketballFileExists, "File was not found");
      Assert.True(footballFileExists, "File was not found");
      Assert.True(baseballFileExists, "File was not found");
      
    }

   //below are tests I wasn't able to implement

    // [Fact]
    // public void SportsMenuChoiceParameterCheck()
    // {
    // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();

    // }

    // //here I want to make sure when I do navigate to the Basketball menu and input 1 for which team it prints the right stuff
    // [Fact]
    // public void LakersInfoDisplayed()
    // {
    //     //Arrange - expected 
    //     string lakerInfo = "sflsjfklsfjskljlf";
         
         //can be used for both menus
        // string userOption = "1";
       // List<Football> tempFootList = new List<Football>();
      // List<Basketball> tempBasketList = new List<Basketball>();
     // List<Baseball> tempBaseList = new List<Baseball>();
    //     //Act - running the method
         
    //     //Assert - compare what actuall happened 
    //     Assert.Equal()
    // }

    // [Fact]
    // public void PatriotsInfoDisplayed ()
    // {
         // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();

    // }

    // [Fact]
    // public void YankeesInfoDisplayed()
    // {
    // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();
    // }

    // [Fact]
    // public void BullsAndWarriorsWinsCompared()
    // {
    // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();
    // }

    // [Fact]
    // public void LakersAndSpursWinsCompared()
    // {
        // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();
    // }

    // [Fact]
    // public void PackersAndBearsWinsCompared()
    // {
      // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();
    // }

    // [Fact]
    // public void AthleticsAndGiantsWinsCompared()
    // {
      // string userOption = "9";
    // List<Football> tempFootList = new List<Football>();
    // List<Basketball> tempBasketList = new List<Basketball>();
    // List<Baseball> tempBaseList = new List<Baseball>();
    // }
 
}