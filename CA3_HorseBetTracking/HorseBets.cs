using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_HorseBetTracking
{
    public class HorseBets : ICollection<HorseBet>
    {
        public List<HorseBet> BetsList = new List<HorseBet>();

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
            throw new NotImplementedException();
        }

        public IEnumerator<HorseBet> GetEnumerator()
        {
            return BetsList.GetEnumerator();
        }

        public bool Remove(HorseBet item)
        {
            return BetsList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
