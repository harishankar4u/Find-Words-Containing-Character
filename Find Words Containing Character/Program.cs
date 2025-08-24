public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FindWordsContaining(["leet", "code"],'e'));// output [0,1]
        Console.WriteLine(FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'z'));// output []
        Console.WriteLine(FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], '2'));// output [0,2]
    }
    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        IList<int> list = new List<int>();
        for(int i=0; i<words.Length; i++)
        {
            string word = words[i];
            // first approach
           //var res= word.IndexOf(x);
           //if(res >=0)
           //     list.Add(i);

            //second approach
            if(word.Contains(x))
            {
                list.Add(i);
            }
        }
        return list;
    }
}