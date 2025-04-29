using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_shepardson_bruce
{
    abstract class Game
    {
      
      public string Esrb { get; set; }
        public string title { get; set; }
        
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
           title = titleParam;
        }
        // <summary>
        //prints a title and says it is starting.
        // <summary>
        public void PlayGame()
         {
            Console.WriteLine($"{title} is starting");
         }

        public abstract string Describe();
    }
  

}
