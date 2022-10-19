public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> sStack = new Stack<char>();
            Stack<char> tStack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '#')
                {
                    if (sStack.Count > 0)
                    {
                        sStack.Pop();
                    }
                    continue;
                }

                sStack.Push(c);
            }

            foreach (var c in t)
            {
                if (c == '#')
                {
                    if (tStack.Count > 0)
                    {
                        tStack.Pop();
                    }
                    continue;
                }

                tStack.Push(c);
            }

            return sStack.SequenceEqual(tStack);
        }
    }