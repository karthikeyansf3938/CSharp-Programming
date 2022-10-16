using System;
namespace SyncfusionCollegeofEngineeringandTechnology
{
    public class KeyValue<TKey,TValue>
    {
        public TKey key{get; set;}
        public TValue value{get; set;}
        private int _count;
        private int _capacity;
        
    }
   
   
}