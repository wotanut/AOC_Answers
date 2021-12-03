using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC
{
    class Program
    {
        static void Main(string[] args)
        {

            // defining some key variables
            int counter = 0;
            int current_number = 0;
            int one_back = 0;
            int two_back = 0;
            int three_back = 0;
            int first_three_total = 0;
            bool need_to_repeat = false;
            List<int> new_totals = new List<int>();
            string textFile = @"C:\Users\blewittsh\source\repos\AOC\input.txt";


            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(textFile))
            {
                // go up three numbers adding them togethor then go down two and repeat, adding the current sum to a list
                if (counter == 0 || counter == 1 || counter == 2)
                {
                    first_three_total = first_three_total + Convert.ToInt32(line);
                    counter = counter + 1;
                }
                else
                {

                }


                // System.Console.WriteLine(line);
                counter = counter + 1;
            }

            // stops the program from closing at the end

            Console.ReadLine();

        }
        }
}
