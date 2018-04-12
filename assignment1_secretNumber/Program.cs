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
            //Console.WriteLine("Det slumpade nummeret är: {0}", slumpTal); // controll of the random number

            Console.Write("Gissa ett nummer mellan 1 och 100: ");
            int gissning = Convert.ToInt32(Console.ReadLine());

            do {
                if(gissning > slumpTal && gissning < 101) {
                    Console.Write("Gissa ett mindre tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else if(gissning < slumpTal && gissning > 0) {
                    Console.Write("Gissa ett större tal: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
                else {
                    Console.Write("Gissa ett nummer mellan 1 och 100: ");
                    gissning = Convert.ToInt32(Console.ReadLine());
                }
            } while(gissning != slumpTal);
            Console.WriteLine("Grattis! Du gissade rätt!");
            Console.ReadLine();
        }
    }
}
