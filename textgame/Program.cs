using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();

            //Initialize the Session
            //creates the player and the map
            Session session = new Session();
            
            Actions.Look(session.player.playerSpace);
            while (true)
            {
                Console.WriteLine();
                session.ProcessInput(Console.ReadLine());
            }
        }
        
        //public Map map = new Map(3, 3, 3);
        public const bool debug = true; //debug messages will be displayed if true
    }
}
