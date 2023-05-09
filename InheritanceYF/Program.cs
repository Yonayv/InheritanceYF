using System;

namespace InheritanceYF
{
    /// <summary>
    /// With our FPS class we make an a new object 'E' & 'ZombCube'
    /// the returned describe is called upon from FPS to be printed in a console writeline
    /// we called the Playgame method on our object
    /// Another FPS class is made to make a new FPS object 'M' 'CS:GO'
    /// the returned describe is called upon from FPS to be printed in a console writeline
    /// we called the Playgame method on our object`
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
