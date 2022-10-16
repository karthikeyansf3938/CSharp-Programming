using System;
namespace ArrayListDs;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList arrays=new ArrayList();
        arrays.Add(10);
        arrays.Add(20);
        arrays.Add(10);
        arrays.Add(10);
        arrays.Add(10);
        arrays.Insert(2,10);
        arrays.RemoveAt(1);
        arrays.Remove(20);
        foreach(var data in arrays)
        {
            System.Console.WriteLine(arrays);
        }
        for(int i=0;i<arrays.Count;i++)
        {
            System.Console.WriteLine(arrays[i]);
        }
    }
}