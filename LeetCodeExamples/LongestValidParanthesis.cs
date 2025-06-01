public class StackNode
{
    public char c;
    public int idx;

    public StackNode(char c, int idx)
    {
        this.c = c;
        this.idx = idx;
    }
}
public class LongestValidParanthesisSolution {
    public int LongestValidParentheses(string s)
    {
        // stores index value of left paranthesis or initial base index
        Stack<int> stack = new Stack<int>();
        int maxLength = 0;

        // initial base index of potential regular substring start
        stack.Push(-1);

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();

                if (stack.Count > 0)
                {
                    maxLength = Math.Max(maxLength, i - stack.Peek());
                }
                else
                {
                    stack.Push(i);
                }
            }
        }

        return maxLength;
    }
}