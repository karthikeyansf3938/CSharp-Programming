using System;
namespace QueueDs;
class Program
{
    public static void Main(string[] args)
    {
        Queue<Type> datas=new Queue<Type>();
        datas.Enqueue(1);
        datas.Enqueue(2);
        datas.Enqueue(3);
        datas.Enqueue(4);
        datas.Enqueue(5);
        datas.Dequeue();
        datas.Peek()
    }
}