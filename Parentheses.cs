using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public static class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            var stack = input.ToCharArray();
            int countOpening = 0;
            int countClosing = 0;
            foreach (var parn in stack)
            {
                if (parn == '(')
                {    
                    countOpening++;
                }

                else if (parn==')')
                {
                    if (countClosing >= countOpening)
                        return false;
                    countClosing++;
                }
                
            }

            return countOpening == countClosing ? true : false;
        }
    }
}