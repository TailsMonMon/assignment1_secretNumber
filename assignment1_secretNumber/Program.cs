using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_secretNumber {
    class Program {
        static void Main(string[] args) {

            Random randomerare = new Random();
            int slumpTal = randomerare.Next(1,101);
            //Console.WriteLine("Det slumpade talet är: {0}", slumpTal); // controll of the random number.
            int antalGissningar = 0;    // Defines and starts with 0 attemps.

            Console.Write("Gissa ett nummer mellan 1 och 100: ");
            int gissning = Convert.ToInt32(Console.ReadLine());

            do {
                if(gissning > slumpTal+15 && gissning <= 100) {     // bigger than slumpTal+15 AND not bigger than 100.
                    Console.Write("Gissa ett mindre tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else if(gissning > slumpTal && gissning <= slumpTal+15) {     // bigger than slumpTal AND smaller than slumpTal+15
                    Console.Write("Nu är du nära, gissa ett mindre tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else if(gissning < slumpTal-15 && gissning >= 1) {  // Smaller than slumpTal-15 AND not smaller than 1.
                    Console.Write("Gissa ett större tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else if(gissning < slumpTal && gissning >= slumpTal-15) {  // Smaller than slumpTal AND bigger than slumpTal-15
                    Console.Write("Nu är du nära, gissa ett större tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else {
                    Console.Write("Gissa ett nummer mellan 1 och 100: ");   // Smaller than 0 OR bigger than 100.
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                antalGissningar++;  // Counts the number of attempts.
            } while(gissning != slumpTal);
            Console.WriteLine("Grattis! Du gissade rätt efter {0} försök!", antalGissningar);
            Console.ReadLine();
        }
    }
}
