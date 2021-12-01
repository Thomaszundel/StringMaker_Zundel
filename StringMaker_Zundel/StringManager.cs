using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Zundel
{
    class StringManager
    {
        private string inputString { get; set; }

        public string Reverse(string s )
        {
            inputString = s;
            string outputString = null;
            string word = s;
            Stack<char> wordStack = new Stack<char>();
            for (int i = 0; i < word.Length; i++)
            {
                wordStack.Push(word[i]);
            }
            for (int i = 0; i < word.Length; i++)
            {
                outputString += wordStack.Pop();
            }

            return outputString;
        }
        public string Reverse(string s, bool PreserveCaseLocation)
        {
            inputString = s;
            if (PreserveCaseLocation == true)
            {
                string finalString = null;
                string outputString = null;
                string word = s;
                Stack<char> wordStack = new Stack<char>();
                Stack<int> uppercaseNums = new Stack<int>();

                for (int i = 0; i < word.Length; i++)
                {
                    wordStack.Push(word[i]);
                    if (char.IsUpper(wordStack.Peek()))
                    {
                        uppercaseNums.Push(i);
                    }
                }
                for (int i = 0; i < word.Length; i++)
                {
                    outputString += wordStack.Pop();
                }
                outputString = outputString.ToLower();
                char[] outputStringLower = outputString.ToCharArray();
                int numOfUpper = uppercaseNums.Count; 

                for (int i = 0; i < numOfUpper ; i++)
                {
                    int temp = uppercaseNums.Pop();
                   
                    outputStringLower[temp] = char.ToUpper( outputStringLower[temp]);

                    
                }
                for (int i = 0; i < outputStringLower.Length; i++)
                {
                    finalString += outputStringLower[i];
                }

                return finalString;
            }
            else
            {
                return Reverse(s);
            }
        }

        public bool Symmetric(string s)
        {
            inputString = s;
            if (Reverse(s)== s)
            {
                return true;
            }
            
            return false;
        }

        public override string ToString()
        {
            string s = inputString;
            int total = 0;
            string name = null;
            foreach (char c in s)
            {
                int singleLetter = 0;
                singleLetter = Convert.ToInt32(c);
                total += singleLetter;
            }
            string namedNumber = total.ToString();
            for (int i = 0; i < namedNumber.Length; i++)
            {
                string temp = null;
                switch (namedNumber[i])
                {
                    case '0':
                        temp = "Zero";
                            break;
                    case '1':
                        temp = "One";
                        break;
                    case '2':
                        temp = "Two";
                        break;
                    case '3':
                        temp = "Three";
                        break;
                    case '4':
                        temp = "Four";
                        break;
                    case '5':
                        temp = "Five";
                        break;
                    case '6':
                        temp = "Six";
                        break;
                    case '7':
                        temp = "Seven";
                        break;
                    case '8':
                        temp = "Eight";
                        break;
                    case '9':
                        temp = "Nine";
                        break;
                    default:
                        temp = "Negative One";
                        break;
                }
                if(i == 0)
                {
                    name = temp;
                }
                else
                {
                    name = name + " " + temp;
                }
            }
            return name;
        }
        public override bool Equals(object obj)
        {
            if (obj.ToString() == inputString && obj is string)
            {
                return true;
            }
                    
            return false;
        }

    }
}
