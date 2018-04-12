using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_secretNumber {
    class Program {
        static void Main(string[] args) {

            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1,101);
            Console.Write(slump_tal);

            Console.ReadLine();
        }
    }
}
