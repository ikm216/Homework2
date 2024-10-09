using System;
/// <summary>
/// The Program class contains the main entry point of the program.
/// It reads a string input from the user, converts it to uppercase,
/// counts the frequency of characters, and then prints the most common character and its count.
/// </summary>
class Program
{
    /// <summary>
    /// It asks the user for a string input, processes it to find the most frequent character, 
    /// and displays that character along with the count of its occurrences.
    /// </summary>
    /// <param name="args">Command-line arguments, if any. Not used in this program.</param>
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        string user = input.ToUpper();

        int[] indexes = new int[128];

        /// <summary>
        /// This loop iterates over each character in the input string.
        /// It checks if the character's ASCII value is within the basic ASCII range (0-127),
        /// and increments the count for that character in the indexes array.
        /// </summary>
        foreach(char i in user){
            if((int)i < 128){ 
                indexes[(int)i]++; 
            }
        }

        int common = 0;
        int count = 0;

        /// <summary>
        /// This loop finds the index of the character with the highest count.
        /// It iterates through the indexes array to find the character with the most occurrences.
        /// </summary>
        for (int i = 1; i < indexes.Length; i++){
            if(indexes[i] > count){
                count = indexes[i];
                common = i;
                
            }
        }
        char most_common = (char)common;

        /// <summary>
        /// This prints the most common character in the string and its count.
        /// If multiple characters have the same count, it will show the first one with the highest count.
        /// </summary>
        Console.WriteLine("'" + most_common + "' " + count);
    }
}