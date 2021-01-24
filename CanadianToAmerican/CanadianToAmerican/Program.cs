using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CanadianToAmerican
{
    class Program
    /*
    PROGRAMME	:	CanadianToAmerican

    OUTLINE	:	Program takes a American name that is within the files and changes it to a canadian file while also displaying what was changed
                program uses regex, arrays, (if,while and foreach) loops. It also uses File.ReadAllLines() to read the contents of the file and uses 
                an array to read each word 1 by 1. The rest will be explained down at the bottom.   

    PROGRAMMER	:	Methunan Uthayakumar

    DATE		:	November 4, 2020


    Console:
    Enter a word to see if its a canadian spelling
    Then press enter after each word

    the color is blue and the flavor is sweet
    the

    Correct Canadian spelling: colour
    The American way you wrote:

    color

    is

    blue

    and

    the

    Correct Canadian spelling: flavour
    The American way you wrote:

    flavor

    is

    sweet
    */
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a word to see if its a canadian spelling \n Then press enter after each word\n"); // user enters word or sentence and will lower to lowercase
                var word = Console.ReadLine().ToLower();

                var filePath = @"E:\C#\CanadianToAmerican\CanadianToAmerican\bin\Debug\netcoreapp2.1\Amer.txt"; // set a variable to read the file 
                string[] fileLine = File.ReadAllLines(filePath); // array making sure all lines in the file are read 
                string[] s = Regex.Split(word, " "); // splits the string after every space 
                var filePath2 = @"E:\C#\CanadianToAmerican\CanadianToAmerican\bin\Debug\netcoreapp2.1\Cana.txt"; // set a variable to read the file 
                string[] fileLine2 = File.ReadAllLines(filePath2); // array making sure all lines in the file are read 

                foreach (string words in s) // goes through every string contained in the array 
                {
                    int num = 0; // set to 0
                    while (num < fileLine.Length) // while loop if the num which is less then the lines length it exercutes the following code
                    {
                        if (words == fileLine[num]) // if the statment is true the name written is there it ends and returns the value to the array represented by aInput
                        {
                            Console.WriteLine("Correct Canadian spelling: " + fileLine2[num] + "\nThe American way you wrote: ");
                            Console.ReadLine();
                            break; // stops executing and moves on to next word 
                        }
                        else // it increases the count and returns the value to the method so num would be 1 instead of 0 and would loop till the space 
                        {
                            num++; //increases count by 1
                        }
                    }
                    Console.WriteLine( words); // prints out the words that are not fixed
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        } 
    }
}
