namespace _1_World_DumbestTest.Testz
{
  public class WorldsDumbestFunction
  {
    public string ReturnPikachuIfZero(int num)
    {
      if (num == 0)
      {
        return "PIKACHU!";
      }
      else
      {
        return "Squirtle";
      }
    }
  }
  // Calling Test WorldsDumbestFunctionTests.WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString(); //
  public static class WorldsDumbestFunctionTests
  {
    public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
    {
      try
      {
        // Arrange
        // Go get your variables, whatever you need, your classes, go get functions
        int num = 1;
        WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

        // Act - Execute the Function
        string result = worldsDumbest.ReturnPikachuIfZero(num);
        // Assert 
        if(result == "PIKACHU!")
        {
          Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnPikachuIfZero");
        } 
        else
        {
          throw new Exception("FAILED: WorldsDumbestFunction.ReturnPikachuIfZero");
        }
      } 
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
