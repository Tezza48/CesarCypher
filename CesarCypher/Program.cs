using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = 13;
            char[] input;
            string output = "";
            

            //get input string
            input = Console.ReadLine().ToCharArray();
            //get bitches
            //convert to char[]
            //get bitches
            //add key to all values

            if (key > 26)
            {
                key -= 26;
            }

            foreach ( char i in input)
            {
                //if i > 26 - key
                if ()
                {
                    output += (char)( i + key );
                }
            }
            //get bitches
            //bring letters that go beyond the alphabet to the start
            //get bitches
        }
    }
}
