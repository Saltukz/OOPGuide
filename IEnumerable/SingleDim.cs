using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample
{
    public class SingleDim : IEnumerable
    {
        public int[] array;
        public SingleDim(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new ArrayEnumerator(this);
        }

        public class ArrayEnumerator : IEnumerator
        {
            private int loc = -1;
            private SingleDim a;

            public ArrayEnumerator(SingleDim a)
            {
                this.a = a;
            }

            public object Current => a.array[loc];

            public bool MoveNext()
            {
                if(loc< a.array.Length - 1)
                {
                    loc++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                loc= -1;
            }
        }
    }
}
