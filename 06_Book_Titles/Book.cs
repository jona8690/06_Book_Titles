using System;
using System.Collections.Generic;

namespace _06_Book_Titles
{
    internal class Book
    {
        private string TitleValue;

        public string Title
        {
            set { this.TitleValue = value; }
            get
            {
                string[] exceptions = { "the","a","an","and","of","in" };
                bool firstword = true;

                string[] getwords = this.Splitstring(this.TitleValue);
                List<string> sreturn = new List<string>(); 
                foreach (string word in getwords)
                {
                    
                    string Capword = word;
                    if (!(Array.IndexOf(exceptions, word) > -1) || firstword  )
                        
                        Capword = Titelize(word); 
                    sreturn.Add(Capword);
                    firstword = false;
                }
                return string.Join(" ", sreturn);
            }
        }

        private string Titelize(string word)
        {
            char firstletter = word[0];
            return char.ToUpper(firstletter) + word.Substring(1);
        }

        private string[] Splitstring(string input)
        {
            char[] space = { ' ' };
            return input.Split(space);
        }


    }


}
