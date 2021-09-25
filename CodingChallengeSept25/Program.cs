using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeSept25
{
    class Program
    {
        static void Main(string[] args)
        {
            string cali = "supercalifragilisticexpialidocious";
            foreach (char letter in cali)
            {
                Console.WriteLine(letter);
            }
            foreach (char letter in cali)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);

                }
                else 
                {
                    Console.WriteLine("Not an i");
                }
            }
            int num = 0;
            foreach (char letter in cali)
            {
                num++;
            }
            ;

            Console.ReadKey();
        }
    }
}
