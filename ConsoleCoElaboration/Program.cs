﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoElaboration
{
    class Program
    {
        /// <summary>
        /// This is the main method
        /// it receives a input from commandline
        /// and checks if its numbers or letter
        /// it will then check if it's a palindrome
        /// if it is a number it will present the same number in binary or roman 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string userİnput = Console.ReadLine();
            if (IsPalindrome(userİnput))
            {
                Console.WriteLine("yes it's a palindrome");    
                
            }
            else
            {
                Console.WriteLine("No it's not a palindrome");
            }
            
            foreach (char value in userİnput)
            {
                bool digit = char.IsDigit(value);
                Console.Write(value);
                Console.Write(' ');
                Console.WriteLine(digit);
            }
        }

        /// <summary>
        /// returns true if input is a Palindrome
        /// else false
        /// </summary>
        /// <param name="text">text input to be validated</param>
        /// <returns></returns>
        private static bool IsPalindrome(String text)
        {
            string first = text.Substring(0, text.Length / 2);
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

        /// <summary>
        /// Returns true if input is only letters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool ContainsOnlyLetters(String text)
        {
            return false;
        }

        public static bool IsCharDigit(char c)
        {
            return ((c >= '0') && (c <= '9'));
        }

        private static bool ConvertToBinaryNumbers(int input)
        {
            return false;
        }

        private static string ConvertToRomanNumbers(String text)
        {
            return null;
        }
    }

}
