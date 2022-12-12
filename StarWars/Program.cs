using StarWars;

TestCannon test= new TestCannon();
test.SetCannons();


public class TestCannon
{
    public void SetCannons()
        {

        List<int> heights = null;
        ICannonLoader cannonLoader = new CannonLoader();
        var NrOfCannons = cannonLoader.GetMaxCannon(heights);
        Console.WriteLine(NrOfCannons);
        }



}



