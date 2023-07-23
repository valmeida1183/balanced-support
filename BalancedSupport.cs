public static class BalancedSupport
{
    private static Stack<char> CharStack = new Stack<char>();
    private static Dictionary<char, char> Mapper = new Dictionary<char, char>();

    public static bool IsBalanced(string? value)
    {
        CharStack.Clear();
        Mapper.Clear();

        Mapper.Add('(', ')');
        Mapper.Add('[', ']');
        Mapper.Add('{', '}');

        if (String.IsNullOrEmpty(value))
        {
            return false;
        }

        var charArray = value.ToCharArray();
        return Validate(charArray);
    }

    private static bool Validate(char[] values)
    {
        foreach (char c in values)
        {
            if (Mapper.ContainsKey(c))
            {
                CharStack.Push(c);
            }
            else
            {
                var count = CharStack.Count;
                if (count == 0)
                {
                    return false;
                }

                var comparator = CharStack.Pop();
                if (Mapper[comparator] != c)
                {
                    return false;
                }
            }
        }

        return CharStack.Count == 0;
    }
}