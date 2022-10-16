using System;
namespace DictionaryDs;
class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> dictionary=new Dictionary<string, int>();
        dictionary.Add("1000",0);
        dictionary.Add("20",1);
        dictionary.Add("30",2);
        dictionary.Add("40",3);
        dictionary.Add("50",4);
        dictionary.ContainsKey("50");
        dictionary.ContainsValue(3);
        dictionary.ElementAt(2);
        dictionary.Remove("30");
    }
}