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

            //Initialize the Map
            Map map = new Map(3, 3, 3);

            //Create a new Player
            string enteredName;
            string input;
            while (true)
            {
                Console.WriteLine("Enter character name:");
                enteredName = Console.ReadLine();
                Console.WriteLine(string.Format("You have entered: \n{0}\nIs this correct?"));
                input = Console.ReadLine();
                if (Methods.IsYesOrNo(input) == null)
                {
                    Console.WriteLine("C'mon. Please enter yes or no, y or n.");
                    Console.ReadLine();
                }
                else
                {
                    if (Methods.IsYesOrNo(input) ?? true)
                    {
                        break;
                    }
                }
            }
            Player player = new Player(enteredName);

            Actions.Look(player.GetPlayerSpace(map));
            while (true)
            {
                input = Console.ReadLine();
                Methods.ProcessInput(input);
            }
        }




        //public Map map = new Map(3, 3, 3);
        public const bool debug = true; //debug messages will be displayed if true
        
    }
}
