using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_HorseBetTracking
{
    public class HorseBets : IList<HorseBet>
    {
        public BindingList<HorseBet> BetsList = new BindingList<HorseBet>();

        public HorseBet this[int index]
        {
            //get => throw new NotImplementedException();
            set => throw new NotImplementedException();
            get => BetsList[index];
            //set => BetsList[index];
        }

        public int Count
        {
            get { return BetsList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(HorseBet item)
        {
            BetsList.Add(item);
        }

        public void Clear()
        {
            BetsList.Clear();
        }

        public bool Contains(HorseBet item)
        {
            return BetsList.Contains(item);
        }

        public void CopyTo(HorseBet[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (arrayIndex < 0 || (array.Length - arrayIndex < Count) )
            {
                throw new ArgumentOutOfRangeException("arrayIndex");
            }            
            for (int i = 0; i < Count; ++i)
            {
                array[i + arrayIndex] = BetsList[i];
            }                
        }

        public IEnumerator<HorseBet> GetEnumerator()
        {
            return BetsList.GetEnumerator();
        }

        public int IndexOf(HorseBet item)
        {
            return BetsList.IndexOf(item);
        }

        public void Insert(int index, HorseBet item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(HorseBet item)
        {
            return BetsList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
