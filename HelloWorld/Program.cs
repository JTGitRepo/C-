using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList typeList = new ArrayList();
            int integerType = 10;
            double doubleType = 10.1;
            char characterType = 'A';
            string stringType = "This is a string.";

            typeList.Add(integerType);
            typeList.Add(doubleType);
            typeList.Add(characterType);
            typeList.Add(stringType);
            string[] outputArray = new string[typeList.Count];

            for (int i = 0; i < typeList.Count; i++)
            {
                outputArray[i] = typeList[i].ToString();
            }
            for(int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine("Array member of index {0} is \"{1}\".", i, outputArray[i]);
            }

            Console.WriteLine("Please enter a searchable sentance.\n");
            string sentence = Console.ReadLine();
            Console.WriteLine("Please enter your search keyword.\n");
            string keyword = Console.ReadLine();
            string keywordFirstLetter = keyword.Substring(0, 1);
            int index = sentence.IndexOf(keywordFirstLetter);

            string sub = sentence.Substring(index, keyword.Length);
            bool keywordFound = false;

            while (keywordFound == false)
            {
                try
                {
                    index = sentence.IndexOf(keywordFirstLetter);
                    sub = sentence.Substring(index, keyword.Length);
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
           
                if (sub == keyword)
                {
                    keywordFound = true;
                }
                else
                {
                    try
                    {
                        sentence = sentence.Substring(index);
                        sentence = sentence.Substring(1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }

            }
            if(keywordFound == true)
            {
                Console.WriteLine("Keyword: {0} was found in your sentance.", keyword);
            }
            else
            {
                Console.WriteLine("Keyword: {0} was NOT found in your sentance.", keyword);
            }

            Console.Read();
        }
    }
}
