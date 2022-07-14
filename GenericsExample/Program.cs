namespace GenericsExample
{
    class Program
    {
        static void Main()
        {
            DummyList<int> myList = new DummyList<int>();
            myList.Add(10);
            myList.Add(20);
            Console.WriteLine(myList.Remove(0));
            Console.WriteLine(myList.RemoveFromEnd());
            myList.Add(30);
            myList.Add(40);
            Console.WriteLine(myList.Remove(1));
            Console.WriteLine(myList.RemoveFromEnd());

        }

        public class DummyList<T>
        {

            int size;
            int indx = -1;
            T[] items;

            public DummyList() : this(10)
            {

            }

            public DummyList(int x)
            {
                size = x;
                items = new T[size];
            }

            public void Add(T item)
            {
                indx++;
                if(indx >= size) throw new IndexOutOfRangeException();
                items[indx] = item;
            }

            public T RemoveFromEnd()
            {
                if (indx >= 0)
                {
                    return items[indx--];
                }
                else throw new InvalidOperationException("The list is Empty");
            }

            public T Remove(int x)
            {
                if(indx >= 0)
                {
                    T item;
                    item = items[x];
                    for (int i = x; i < indx; i++) items[i] = items[i + 1];
                        indx--;
                    return item;

                }

                throw new InvalidOperationException("The list is empty");

            }
        }
    }
}