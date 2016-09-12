using System.Globalization;

namespace _03_Simon_Says
{
    internal class Simon
    {
        public string Echo(string s)
        {
            return s.ToLower();
        }

        public string Shout(string s)
        {
            return s.ToUpper();
        }

        public string Repeat(string s)
        {
            return s + " " + s;
        }

        public string Repeat(string s, int n)
        {
            string r = s;
            for (int i = n; i > 1; i--)
            {
                r = r + " " + s;
            }
            return r;
        }

        public string StartOfWord(string s, int n)
        {
            return s.Substring(0, n);
        }

        public string FirstWord(string s)
        {
            return s.Substring(0, s.IndexOf(" "));
        }

        public string Titleize(string s)
        {
            string[] r = s.Split(' ');
            string re = "";

            foreach (var item in r)
            {
                if (item == "and" || item == "the" || item == "over")
                {
                    re = re + " " + item; 
                }
                else
                {
                    re = re + " " + item.Substring(0, 1).ToUpper() + item.Substring(1);
                }
            }
            re = re.TrimStart();
            return re.Substring(0, 1).ToUpper() + re.Substring(1);
        }


    }
}