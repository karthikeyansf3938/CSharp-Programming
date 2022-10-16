using System;
namespace SyncfusionCollegeofEngineeringandTechnology;

    public partial class Dictionary<TKey,TValue>
    {
        private int _count=0;
        private int _capacity=0;
        public KeyValue<TKey,TValue>[] Array{get; set;}
        public Dictionary(int size)
        {
             if(size>0)
            {
                _count=0;
                _capacity=size*2; 
                Array = new KeyValue<TKey,TValue>[_capacity];
            }
        }
        public Dictionary()
        {
            _count=0;
            _capacity=3;
            Array = new KeyValue<TKey,TValue>[_capacity];
        }
        public TValue this[TKey key]//indexer
        {
            get
            {
                TValue output=default(TValue);
                int index=0;
                bool temp = LinearSearch(key, out index);
                if(temp)
                {
                    output=Array[index].value;
                }
                else
                {
                    Console.WriteLine($"Invalid Key");
                    
                }
                return output;
            }
            set
            {
                int position=0;
                bool temp = LinearSearch(key, out position);
                if(position>=0)
                {
                    Array[position].value=value;
                }
                else
                {
                    System.Console.WriteLine("Invalid key");
                }
            }
        }
    }
