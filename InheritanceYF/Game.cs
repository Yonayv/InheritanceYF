using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceYF
{
    /// <summary>
    /// abstract parent class Game  was established
    /// public string Esrb will get and set
    /// public string Title will get and set
    /// public Game allows access to the string esrb & title and setting them as Params
    /// public method Playgame that will print title to console using interpolation
    /// public abstract string describe it returns a string value
    /// </summary>
    abstract class Game
    {


        public string Esrb { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }


        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");

        }

        public abstract string Describe();

    }
}
