using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_shepardson_bruce
{
    internal class FPS : Game
    {      
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        { 
           title = titleParam;  
           Esrb = esrbParam;
        }
        
        
        public override string Describe()
        {   // tells what the fps is rated.
            return $"{title} is a fps game rated {Esrb}";
        }
    }
}
