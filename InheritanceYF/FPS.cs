using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceYF
{
    /// <summary>
    /// class FPS inheirts from the Game class
    /// public FPS is inherited from the base we can assign the Esrb & Title as Params
    /// public override string Desribe returns the Title & Esrb as an interpolation 
    /// The return is overried so that that it differs from the base.
    /// </summary>
    class FPS : Game
    {
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
