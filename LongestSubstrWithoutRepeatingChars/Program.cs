namespace LongestSubstrWithoutRepeatingChars{
    
    public class LongestSubstrWithoutRepeatingChars
    {
        public static void Main(string[] args)
        {
            string s = "aab";
            int result = LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }
        
        public static int LengthOfLongestSubstring(string s)
        {
            var biggestStr = "";
            var Index = 0;
            var Max = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (biggestStr.Contains(s[i]))
                {
                    biggestStr = "";
                    i = Index;
                    Index++;
                }
                else
                {
                    biggestStr += s[i];
                    if (Max < biggestStr.Length) Max = biggestStr.Length;
                }
            }

            return Max;
            
        }
    }


}