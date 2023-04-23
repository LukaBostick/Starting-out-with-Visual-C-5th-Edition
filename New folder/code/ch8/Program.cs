using System.Collections.Generic;
using System.Reflection;

namespace Program
{
    internal class ch8
    {
        private static void Main(string[] args)
        {
            try
            {
                List<string> bsa = new List<string>();

                bool isA = IsTrue(initCh7List(ref bsa));
                if (isA)
                {
                    Console.WriteLine("A was found");
                }
                else
                {
                    Console.WriteLine("A was not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

            private static bool IsTrue(List<string> arry)
            {
            string output = "";
                foreach (string s in arry)
            {
                output += s + "\n";
                
                if(char.Parse(s) == 'A')
                {
                    Console.WriteLine(output);
                    return true;

                }
                
            }
            Console.WriteLine(output);
            return false;
        }
            public static List<string> initCh7List(ref List<string> bsa)
            {
            try
            {

                int rand = 0;
                char ch;

                foreach (string str in bsa)
                {
                    rand = new Random().Next(65, 90);

                    ch = (char)('A' + rand);

                    str.Append(ch);

                    Console.WriteLine(str);
                }
                return bsa;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return bsa;
            }
            }
            private int BinarySearch(int[] iArray, int value)
            {
                int first = 0;              // First array element
                int last = iArray.Length - 1; // Last array element
                int middle;                 // Midpoint of search
                int position = -1;          // Position of search value
                bool found = false;         // Flag

                // Search for the value.
                while (!found && first <= last)
                {
                    // Calculate the midpoint.
                    middle = (first + last) / 2;

                    // If value is found at midpoint...
                    if (iArray[middle] == value)
                    {
                        found = true;
                        position = middle;
                    }
                    // else if value is in lower half...
                    else if (iArray[middle] > value)
                    {
                        last = middle - 1;

                    }
                    // else if value is in upper half...
                    else
                    {
                        first = middle + 1;
                    }
                }

                // Return the position of the item, or -1
                // if it was not found.
                return position;
            }
        
    

        public static bool isStrASentence(string str)
        {
            char[] chars = str.ToCharArray();
            int lengthOfArry = chars.Length;

            if(char.IsPunctuation(chars[lengthOfArry - 1])&&char.IsUpper(chars[0]))
            {
                return true;
            }

            return false;
        }


        public static string reverseStr(String str)
        {
            char[] chars = str.ToCharArray();
            int lengthOfArry = chars.Length;
            string output = "";
            
            for(int i = lengthOfArry-1; i >= 0 ; i--)
            {
                char c = chars[i];
                output+= c;
            }
            return output;
        }


        public static string nFormatDouble(String num)
        {
            decimal inPut = decimal.Parse(num);

            return string.Format("the double is: {0:N1}",inPut);
        }

    

    }

   

     
   
}