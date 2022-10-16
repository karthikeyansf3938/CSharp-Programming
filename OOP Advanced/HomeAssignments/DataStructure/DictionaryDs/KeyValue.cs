using System;
namespace DictionaryDs
{
    public class KeyValue<TKey,TValue>
    {
        public TKey key{get; set;}
        public TValue value{get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
    }
   
}