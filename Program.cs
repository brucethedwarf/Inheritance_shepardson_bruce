namespace Inheritance_shepardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {    // the games and their ratings.
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());    
            myFPS.PlayGame();
            FPS csGO = new FPS("M", "CS:GO");
            
            Console.WriteLine(csGO.Describe());    
            csGO.PlayGame();
        
        }   

    }
}