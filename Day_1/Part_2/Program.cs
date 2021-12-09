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


            /// plan

            // firstly it goes through input.txt and adds up three numbers
            // writes this output to output.txt
            // might just re use the python code that I wrote earlier to loop through output.txt and compare them



            // defining some key variables
            int current_number = 0;
            int for_each_loops = 0;
            string textFile = 
            string output = 
            int first_loop = 0;
            int second_loop = 0;
            bool next = false;


            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(textFile))
            {
                StreamReader sr = new StreamReader(textFile);
                

                // can't get the nth line of a file so must loop through each line of the file to try and find it

                int one = for_each_loops + 1;
                int two = for_each_loops + 2;

                foreach (string new_line in File.ReadLines(textFile))
                {
                    // Console.WriteLine(new_line);
                    if (first_loop == one)
                    {

                        one = Convert.ToInt32(new_line);
                        second_loop = first_loop;
                        next = true;
                    }
                    else if(next == true)
                    {
                        two = Convert.ToInt32(new_line);
                        next = false;
                    }
                    else
                    {
                        first_loop = first_loop + 1;
                        second_loop = second_loop + 1;
                    }
                }

                first_loop = 0;
                second_loop = 0;
                Console.WriteLine(line + " + " + one + " + " + two);

                current_number = Convert.ToInt32(line) + Convert.ToInt32(one) + Convert.ToInt32(two);
                Console.WriteLine(current_number);

                string write = Convert.ToString(current_number);

                StreamWriter sw = File.AppendText(output);
                sw.WriteLine(write);
                sw.Close();
                for_each_loops = for_each_loops + 1;
                // File.AppendText(output, write);
            }

            // stops the program from closing at the end

            Console.ReadLine();

        }
    }
}
