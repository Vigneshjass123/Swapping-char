using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping_the_char
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String a = "abcdefg";//swapping the string of char
            char[] c = a.ToCharArray();
            char temp = c[0];
            c[0] = c[1];
            
            c[1] = temp;
            char temp1 = c[4];
            c[4] = c[5];
            c[5] = temp1;

            {
                Console.WriteLine(c);
            }


        }
    }
}
