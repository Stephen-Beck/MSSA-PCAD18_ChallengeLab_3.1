/*
Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). 
Assume that string may consist only of lower-case letters.

Expected input and output
    IsPalindrome("eye") → true
    IsPalindrome("home") → false
*/

namespace ChallengeLab_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a string: ");
                string userInput = Console.ReadLine().ToLower().Replace(" ","");

                Console.WriteLine($"{userInput} is a palindrome: {IsPalindrome(userInput)}\n");
            }
        }

        static bool IsPalindrome(string input)
        {
            //This would be a more readable way of doing this:
            int l = 0;
            int r = input.Length - 1;

            while (l < r)
            {
                if (input[l] != input[r])
                    return false;

                l++;
                r--;
            }
            return true;
        }

        static bool IsPalindrome(string input, string unusedVariableToForceAnOverload)
        {
            // I believe this (unused) solution would save a whopping 4 bytes of memory by using one less int variable
            // It's also MUCH harder to read for a human

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
