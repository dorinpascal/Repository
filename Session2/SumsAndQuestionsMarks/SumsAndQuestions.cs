using System;
using System.Linq;

namespace SumsAndQuestionsMarks
{
    public class SumsAndQuestions
    {
        public string GenerateRandomString()
        {
            const string str = "?aqwe?rtyuiops?dfghjk?lzxcvb?nm0123?45678?9";
      
            string y = new string(str.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());

            string x = y.Substring(0, 20);
            
            
            return x;
        }


        public int FindSums(string s)
        {
            string x;
            int count = 0;
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals("?"))
                {
                    count = i;
                }
                
            }
        }
        
        
        
        
    }
}