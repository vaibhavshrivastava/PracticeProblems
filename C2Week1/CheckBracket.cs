using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Week1
{
    public class CheckBracket
    {
        public class Bracket
        {
            public char type;
            public int position;
            public bool Match(char c)
            {
                if (this.type == '[' && c == ']')
                    return true;
                if (this.type == '{' && c == '}')
                    return true;
                if (this.type == '(' && c == ')')
                    return true;
                return false;
            }
        }

        public int Check_Brackets(string input)
        {
            Stack<Bracket> BracketStack = new Stack<Bracket>();
            for (int i = 0; i < input.Length; i++)
            {
                char next = input[i];
                if (next == '(' || next == '{' || next == '[')
                { 
                    BracketStack.Push(new Bracket {type=next,position=i});
                }
                else if(next == ')' || next == ']' || next == '}')
                {
                    var StackOut=BracketStack.Pop();
                    if (StackOut.Match(next))
                    { continue; }
                    else
                    {
                        return i + 1;
                    }
                }
            }

            if (BracketStack.Count > 0)
            {
                var lastBracket = BracketStack.Pop();
                return lastBracket.position + 1;
            }

            return -1;
        }
    }
}
