using System;
using System.Collections.Generic;
using System.Linq;

namespace algo
{
    class Program
    {
        static void Main(string[] args) {
            var test = "Hello World !";
            Console.WriteLine(PigIt(test));
            Console.WriteLine(PigIt2(test));

        }

        public static string[] Solution(string str)
        {
            var str2 = str.ToArray();
            List<string> res = new List<string>();
            for (var i = 0; i < str2.Length; i++)
            {
                if (str.Length % 2 != 0 && str2.Length - i == 1)
                {
                    res.Add(str2[i] + "_");
                }
                else if (i % 2 != 0 && i != 0)
                {
                    res.Add($"{str2[i - 1]}{str2[i]}");
                }
            }
            return res.ToArray();
        }

        public static string PigIt(string str)
        {
            var strL = str.Split(" ").ToList();
            var res = new List<string>();
            
            for (var i = 0; i < strL.Count(); i++)
            {
                if(strL[i].Length == 1 && Char.IsPunctuation(strL[i].ToCharArray()[0]))
                {
                    res.Add($"{strL[i]}");
                }
                else
                {
                    res.Add(strL[i].Substring(1) + strL[i][0] + "ay");
                } 
            }
            
            return string.Join(" ", res);
        }

        public static string PigIt2(string str)
        {
            List<string> res = new List<string>();
            var wordArray = str.Split(" ");
            foreach (var word in wordArray)
            {
                if (Char.IsPunctuation(word.ToCharArray()[0]))
                    res.Add(word);
                else
                {
                    res.Add(word[1..] + word[0]+ "ay");
                }

            }
            return string.Join(" ", res);
        }
        public static bool comp(int[] a, int[] b)
        {
            List<int> res = new List<int>();
            foreach(var i in b)
            {
                foreach(var j in a)
                {
                    if(j * j == i)
                    {
                        res.Add(j);
                    }
                }
            }
            var checker = a.ToList();
            if (res.Distinct().Count() == checker.Distinct().Count())
            {
                Console.WriteLine(string.Join(",", res));
                Console.WriteLine(string.Join(",", checker));
                return true;
                
            }
            return false;
        }

        public static int KK(string[] a)
        {
            List<string> res = new List<string>();
            foreach (var word in a)
            {
                if (IsPalindrome(word))
                {
                    res.Add(word);
                }
            }
            return res.Count();
        }

        public static bool IsPalindrome(string w)
        {
            if (Equals(w, string.Join("",w.Reverse())))
                return true;
            return false;
        }



        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            // Happy Coding :)
            return 0;
        }

        public static bool FbyZero(int number)
        {
            var numarray = number.ToString().Select(num => (Convert.ToInt32(num) - 48)).ToList();
     
            return numarray.Count(it => it == 0) == numarray.Count() - 1;
        }

        public static bool Decre(int number)
        {
            var numarray = number.ToString().Select(num => (Convert.ToInt32(num) - 48)).ToList();
            return numarray.Zip(numarray, (a, b) => (a - 1) == b).All(x => x);
        }
        public static bool Incre(int number)
        {
            var numarray = number.ToString().Select(num => (Convert.ToInt32(num) - 48)).ToList();

            if(numarray[numarray.Count() - 1] == 0)
            {
                numarray.RemoveAt(numarray.Count() - 1);
            }
            return numarray.Zip(numarray, (a, b) => (a + 1) == b).All(x => x);
        }


    }


}
