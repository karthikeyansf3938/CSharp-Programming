using System.Collections;
namespace SyncfusionCollegeofEngineeringandTechnology;
    public partial class Dictionary<TKey,TValue> : IEnumerable,IEnumerator
    {
        private int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return(IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position < _count-1)
            {
                ++position;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset() //REsets i for next turn
        {
            position = -1;
        }
        public object Current //Returns the current array position value
        {
            get { return Array[position];}
        }
        
    }
