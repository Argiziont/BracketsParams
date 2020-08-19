using System;
using System.Linq;

namespace BracketsParams
{
    public class Brackets
    {
        static void Main(string[] args)
        {
            var z ="()".ToCharArray();
            string str = Console.ReadLine();
            if (BracketTest(str,'(', ')', '{', '}', '[', ']'))
            {
                Console.WriteLine("FineLine");
            }
            else
            {
                Console.WriteLine("WrongLine");
            }

            Console.ReadKey();
        }
        public static bool BracketTest(string bracketstring, params char[] brackets)
        {
            bool trueString=true;
                for (int i = 0; i < brackets.Length; i+=2)
                {
                    char left = brackets[i];
                    char right = brackets[i + 1];
                   // Console.WriteLine($"{left} { right}\n");
                    int bracketcount = bracketstring.Count(x => x == left);
                    if (bracketstring.Count(x => x == right) == bracketcount)//If number of brackets isn't even=> skip all logic
                    {
                        for (int j = 0; j < bracketcount; j++)
                        {
                            int tmpfirst = bracketstring.IndexOf(left);
                            int tmpsecond = bracketstring.IndexOf(right);
                            if ((tmpsecond > tmpfirst) && (tmpfirst != -1) && (tmpsecond != -1))// if close-bracket goes after open-one=> delete both of them
                            {
                                bracketstring = bracketstring.Remove(tmpfirst, 1).Remove(tmpsecond - 1, 1);
                            }
                            else
                                break;
                        }
                    }
                    if (bracketstring.IndexOfAny(new char[] { left,right}) != -1)//if we dont find any bracket then this string is right 
                        trueString=false;
                }
                return trueString;
        }
    }
}
