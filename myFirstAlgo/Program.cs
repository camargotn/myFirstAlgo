using System;

public class Program
{
    public static void Main()
    {
        int result = firstOcurrence("aatestsathidbutthiagohotsad", "thiago");

        Console.WriteLine(result);
    }

    static int firstOcurrence(string haystack, string needle)
    {
        string key = needle;
        string text = haystack;

        if (!text.Contains(key))
        {
            return -1;
        }

        int keyLength = key.Length;
        int i = 0;
        int index = 0;

        foreach (char ch in text)
        {
            index++;
            if (ch == key[i])
            {
                if (i + 1 == keyLength)
                {
                    return index - keyLength;
                }
                i++;
            }
        }

        return -1;
    }
}
