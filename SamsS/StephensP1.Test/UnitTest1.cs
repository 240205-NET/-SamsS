using Serializer;
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

      bool fileExists = File.Exists(path);

      Assert.IsTrue(fileExists, "File could not be found");
    }

    //Here I want to make sure the file is created after we exit the program
    // [Fact]
    // public void checkForBasketballFileAfterRun()
    // {
    //     string path = @".\Basketball.txt"

    //     //logic to run my program and exit it, will need to enter a 0 when the menu pops up

    //    bool fileExists = File.Exists(path);

    //    Assert.IsTrue(fileExists, "File still couldn't be found");
      
    // }

    // [Fact]
    // public void SportsMenuChoiceParameterCheck()
    // {

    // }

    // //here I want to make sure when I do navigate to the Basketball menu and input 1 for which team it prints the right stuff
    // [Fact]
    // public void LakersInfoDisplayed()
    // {
    //     //Arrange - expected 
    //     string lakerInfo = "sflsjfklsfjskljlf";
    //     //Act - running the method
         
    //     //Assert - compare what actuall happened 
    //     Assert.Equal()
    // }

    // [Fact]
    // public void PatriotsInfoDisplayed ()
    // {

    // }

    // [Fact]
    // public void YankeesInfoDisplayed()
    // {

    // }

    // [Fact]
    // public void BullsAndWarriorsWinsCompared()
    // {

    // }

    // [Fact]
    // public void LakersAndSpursWinsCompared()
    // {

    // }

    // [Fact]
    // public void PackersAndBearsWinsCompared()
    // {

    // }

    // [Fact]
    // public void AthleticsAndGiantsWinsCompared()
    // {

    // }
 
}