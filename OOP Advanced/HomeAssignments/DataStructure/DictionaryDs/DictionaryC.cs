using System;
namespace DictionaryDs;
public partial class Dictionary<TKey,TValue>
{
    public void Add(TKey key,TValue value)
    {
        if(_count == _capacity)//if _count == _capacity then it increase the capacity
        {
            GrowSize();
        }
        bool temp=LinearSearch(key,out int index);
        if(temp==true)
        {
            Console.WriteLine($"Duplicate value");   
        }
        if(temp==false)
        {
            KeyValue<TKey,TValue> entry = new KeyValue<TKey, TValue>();
            entry.key=key;
            entry.value=value;
            Array[_count] = entry;
            _count++;
        }
    }

    public void GrowSize()
    {   
        _capacity=_capacity*2;
        KeyValue<TKey,TValue>[] Array1 = new KeyValue<TKey,TValue>[_capacity];

        for(int i=0;i<_count;i++)
        {
            Array1[i]=Array[i];
        }
        Array=Array1;  
    }
    public bool LinearSearch(TKey key,out int index)
    {
        index = -1;
        for(int i=0; i<_count;i++)
        {
            if(Array[i].key.Equals(key))
            {
                index = i;
                return true;
            }
        }
        return false;
    }
    public bool ContainsKey(TKey key)
    {
        for(int i=0;i<_count;i++)
        {
            if(Array[i].key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }
    public bool ContainsValue(TValue value)
    {
        for(int i=0;i<Array.Length;i++)
        {
            if(Array[i].value.Equals(value))
            {
                return true;
            }
        } 
        return false;
    }
    public KeyValue<TKey,TValue> ElementAt(int index)
    {
        if(-1<index && index<_count)
        {
           return Array[index];
        }
        else
        {
            Console.WriteLine($"Out of bound"); 
        }
        return Array[index];
    }
    public void Remove(TKey key)
    {
        KeyValue<TKey,TValue>[] newArray=new KeyValue<TKey,TValue>[_capacity];
        int j=0;
        for(int i=0;i<_count;i++)
        {
            if(Array[i].Equals(key))
            {
                i++;
            }
            newArray[j]=Array[i];
            _count--;
        }
    }

}