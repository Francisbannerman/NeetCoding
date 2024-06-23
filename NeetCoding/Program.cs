using System.Collections;

namespace NeetCoding;

class Program
{
    public static void Main(string[] args)
    {
        Array_Hash arrayHash = new Array_Hash();
        Console.WriteLine();

        Console.WriteLine("Duplicate_Integer");
        int[] arr = new int[] { 31, 1, 4, 5, 6, 8, 9, 12, 17, 23, 31 };
        arrayHash.DuplicateInteger(arr);
        Console.WriteLine();

        Console.WriteLine("Is_Anagram");
        string string1 = "racecar";
        string string2 = "carrace";
        arrayHash.IsAnagram(string1, string2);
        Console.WriteLine();

        Console.WriteLine("Two_Sum");
        int[] nums = new int[] { 5,5 };
        arrayHash.TwoSum(nums, 10);
        
        
        Console.ReadKey();
    }
}

public class Array_Hash()
{
    public bool DuplicateInteger(int[] nums)
    {
        //Given an integer array nums, return true if any value
        //appears morethan once in the array, otherwise return false.
        HashSet<int> newHash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (newHash.Contains(nums[i]))
            {
                Console.WriteLine("true");
                return true;
            }
            newHash.Add(nums[i]);
        }
        Console.WriteLine("False");
        return false;
    }

    public bool IsAnagram(string s, string t)
    {
        // Given two strings s and t, return true if the two strings 
        // are anagrams of each other, otherwise return false.
        // An anagram is a string that contains the exact same 
        // characters as another string, but the order of
        // the characters can be different.
        if (s.Length != t.Length)
        {
            Console.WriteLine("false");
            return false;
        }
        List<char> list = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            list.Add(s[i]);
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (list.Contains(t[i]))
            {
                list.Remove(t[i]);
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
        if (list.Count == 0)
        {
            Console.WriteLine("true");
            return true;
        }
        Console.WriteLine("false");
        return false;
    }

    public int[] TwoSum(int[] nums, int target)
    {
        // Given an array of integers nums and an integer target,
        // return the indices i and j such that 
        // nums[i] + nums[j] == target and i != j. You may assume that every input
        // has exactly one pair of indices i and j that satisfy the condition.
        // Return the answer with the smaller index first.

        int[] answer = new int[2];
        HashSet<int> hash = new HashSet<int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int secvalue = target - nums[i];
            if (hash.Contains(secvalue))
            {
                int secIndex = Array.IndexOf(nums, secvalue);
                if (secIndex > i)
                {
                    answer[0] = i;
                    answer[1] = secIndex;
                }
                else if (secvalue == nums[i])
                {
                    answer[0] = secIndex;
                    answer[1] = i;
                }
                else
                {
                    answer[0] = secIndex;
                    answer[1] = i;
                }
                Console.WriteLine($"{answer[0]} - {answer[1]}");
                return answer;
            }
            hash.Add(nums[i]);
        }
        Console.WriteLine("null");
        return null;
    }
}

