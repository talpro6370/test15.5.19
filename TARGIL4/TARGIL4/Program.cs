using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARGIL4
{
    class Program
    {
        static void Main(string[] args)
        {
            char user_char;
            List<string> listt = new List<string>()
            {
                "HEY","SUP","DAMN","HELLO","WHAT"
            };
           // Console.WriteLine(listt[0]);
            Random rnd = new Random();
            int word = rnd.Next(1, listt.Count());
            Console.WriteLine(listt[word-1]);
            int num = listt[word].Count();
            string arr;
            arr = listt[num-1]; /// word to guess
            for (int i = 0; i < num; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("Please pick a char :");
            // user_char = Convert.ToChar(Console.ReadLine());
            char[] c = new char[num];
            int count = 0;
            do
            {
                user_char = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] == user_char)
                    {
                        Console.Write(arr[i]);
                        c[i] = user_char;
                        count++;
                    }
                    if (arr[i] != user_char)
                    {
                        Console.Write(c[i]);
                        
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
                
            } while (count!= num);
        }
    }
}
