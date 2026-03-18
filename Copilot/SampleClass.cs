using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copilot
{
    public class SampleClass  // Changed from 'internal' to 'public'
    {
        // Method 1: Basic approach - Easy to read
        public static bool IsPalindrome_Basic(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Method 2: Optimized approach - No allocations, best performance
        public static bool IsPalindrome_Optimized(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        // Method 3: For alphanumeric only - Ignores spaces and punctuation
        public static bool IsPalindrome_AlphanumericOnly(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(input[left]))
                    left++;

                while (left < right && !char.IsLetterOrDigit(input[right]))
                    right--;

                if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        // Method 4: Using Span<char> for .NET Framework 4.8 (requires NuGet package System.Memory)
        //public static bool IsPalindrome_Span(ReadOnlySpan<char> input)
        //{
        //    if (input.IsEmpty)
        //        return true;

        //    int left = 0;
        //    int right = input.Length - 1;

        //    while (left < right)
        //    {
        //        if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
        //            return false;

        //        left++;
        //        right--;
        //    }

        //    return true;
        //}

        // Example usage
        public static void Main(string[] args)
        {
            string[] testCases = 
            {
                "racecar",
                "A man, a plan, a canal: Panama",
                "hello",
                "Madam",
                "Was it a car or a cat I saw?",
                ""
            };

            Console.WriteLine("=== Basic Approach ===");
            foreach (var test in testCases)
            {
                Console.WriteLine($"'{test}' -> {IsPalindrome_Basic(test)}");
            }

            Console.WriteLine("\n=== Optimized Approach ===");
            foreach (var test in testCases)
            {
                Console.WriteLine($"'{test}' -> {IsPalindrome_Optimized(test)}");
            }

            Console.WriteLine("\n=== Alphanumeric Only (ignores spaces/punctuation) ===");
            foreach (var test in testCases)
            {
                Console.WriteLine($"'{test}' -> {IsPalindrome_AlphanumericOnly(test)}");
            }

            Console.ReadLine();
        }
    }
}
