namespace Program
{
    class ch8
    {
        static void Main(string[] args)
        {
            string str = "Is this sentence properly Capitalized and punctuated.";

            Console.WriteLine(isStrASentence(str).ToString());


            string str2 = "gravity";

            Console.WriteLine(reverseStr(str2));

            string str3 = "12345.6789";

            Console.WriteLine(nFormatDouble(str3));

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