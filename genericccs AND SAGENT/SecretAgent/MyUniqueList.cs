using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            try
            { 
              if (!list.Contains(item))
              {
                list.Add(item);
                return true;
              }

              return false;
            }
            catch (ItemAlreadyExistException i)
            {
                throw (i);
            }
        }

        public bool Remove(int item)
        {
            try
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                    return true;
                }
            }
            catch(ItemNotFoundException n)
            {
                throw (n);
            }
            return false;
        }

        public int Peek(int index)
        {
            try
            {
                return list[index];
            }
            catch(IndexOutOfRangeException o)
            {
                throw (o);
            }
        }

        public int this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}
