using System;
namespace Listds
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> datas=new List<int>();
            datas.Add(10);
            datas.Add(20);
            datas.Add(30);
            datas.Insert(2,10);
           // datas.RemoveAt(1);
            //datas.Remove(20);
           foreach(var data in datas)
            {
                System.Console.WriteLine(datas);
            }
            for(int i=0;i<datas.Count;i++)
            {
                System.Console.WriteLine(datas[i]);
            }
        }
    }
}
