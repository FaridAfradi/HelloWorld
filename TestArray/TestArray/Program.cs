using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray {
    internal class Program {
        static void Main(string[] args) {


            string[] testLoop = new string[] { "Nuuu", "Skaaaall ", "Viii!", "Array-trolla"};

            for (int i = 0; i < testLoop.Length; i++) {

                Console.WriteLine(testLoop[i]);
            }

           

            int siffra;
            Console.WriteLine("\nHur gammal är du din gamla gädda?");
            siffra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOkej, du är alltså " + siffra + " år gammal");

            string name;
            Console.WriteLine("Vad heter du?");
            name = Console.ReadLine();
            Console.WriteLine("\nTjenareeeee " + name + "!");

            
            
                Console.WriteLine("Hur lång är du angivet i CM?");
                int längd = Convert.ToInt32(Console.ReadLine());

            if (längd < 190) 
            {
                Console.WriteLine("\nDu är för kort, kom tillbaka när du är längre");
                
            }

            else 
            {
                Console.WriteLine("Respect bigboiiii!!!");
            }

                 Console.ReadKey(true);



           


        }
    }
}
