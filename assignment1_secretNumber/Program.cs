using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_secretNumber {
    class Program {
        static void Main(string[] args) {

            //      DEFINITIONS AND MAKING OF RANDOMERARE
            Random randomerare = new Random();
            int slumpTal = randomerare.Next(1,101);
            //Console.WriteLine("Det slumpade talet är: {0}", slumpTal); // controll of the random number.
            int gissning = 0;   // Defines the variable before the do-while-loop.
            int antalGissningar = 0;    // Defines and starts with 0 attemps.

            //      INTRO
            Console.WriteLine("=== Gissa nummeret ===");
            Console.Write("Gissa ett nummer mellan 1 och 100: ");
            
            do {
                //      INPUT
                try {
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException) {
                    Console.WriteLine("Ojdå! Detdär är ingen siffra...");
                }

                //      OUTPUT
                if(gissning > slumpTal+15 && gissning <= 100) {     // bigger than slumpTal+15 AND not bigger than 100.
                    Console.Write("Gissa ett mindre tal: ");
                }
                else if(gissning > slumpTal && gissning <= slumpTal+15) {     // bigger than slumpTal AND smaller than slumpTal+15.
                    Console.Write("Nu är du nära, gissa ett mindre tal: ");
                }
                else if(gissning < slumpTal-15 && gissning >= 1) {  // Smaller than slumpTal-15 AND not smaller than 1.
                    Console.Write("Gissa ett större tal: ");
                }
                else if(gissning < slumpTal && gissning >= slumpTal-15) {  // Smaller than slumpTal AND bigger than slumpTal-15.
                    Console.Write("Nu är du nära, gissa ett större tal: ");
                }
                else if(gissning != slumpTal) {     // Smaller than 0 OR bigger than 100. Does not need to be written since it's last in the else-if.
                    Console.Write("Gissa ett nummer mellan 1 och 100: ");   // Smaller than 0 OR bigger than 100.
                }
                //      ENDING
                antalGissningar++;  // Counts the number of attempts.
            } while(gissning != slumpTal);
            Console.WriteLine("Grattis! Du gissade rätt efter {0} försök!", antalGissningar);
            Console.ReadLine();
        }
    }
}
