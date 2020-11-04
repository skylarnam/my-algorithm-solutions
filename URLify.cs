public class StringExtensions
{
    public static string URLify(this char[] str)
    {
        const char Whitespace = ' ';
        var spaces = 0;
        var i = 0;
        
        // First, count the total number of spaces
        for (i = 0; i < str.Length; i++)
        {
            if (str[i].Equals(Whitespace))
            {
                spaces++;
            }
        }
        
        // Since we're going to ignore the spaces at the end, calculate the total "actual" number of spaces
        while (str[i - 1].Equals(Whitespace))
        {
            spaces--;
            i--;
        }
        
        var curr = str.Length - 1;
        var start = curr;
        
        // We're going to start with the first place from the end that isn't a whitespace
        while (str[start].Equals(Whitespace))
        {
            start--;
        }
        
        // Substitute whitespaces with %20 and move characters appropriately until there's no space left
        while (spaces > 0)
        {
            if (str[start].Equals(Whitespace))
            {
                str[curr--] = '0';
                str[curr--] = '2';
                str[curr--] = '%';
                start--;
                spaces--;
            }
            else
            {
                str[curr--] = str[start--];
            }
        }
        
        return new string(str);
    }
}
