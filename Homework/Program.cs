using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for a string
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        string user = input.ToUpper();

        int[] indexes = new int[128];

        //Iterates the string
        foreach(char i in user){
            if((int)i < 128){ //Checks the ASCII
                indexes[(int)i]++; 
            }
        }

        int common = 0;
        int count = 0;

        //Finds the index the of the character having the highest count
        for (int i = 1; i < indexes.Length; i++){
            if(indexes[i] > count){
                count = indexes[i];
                common = i;
                
            }
        }
        char most_common = (char)common;

        //Prints the most common character in the string with the count
        Console.WriteLine("'" + most_common + "' " + count);
    }
}