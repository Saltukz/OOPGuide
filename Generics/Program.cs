namespace Generics
{
    class Program
    {
        static void Main()
        {
            int a, b;
            string p,q;
            a = 5;
            b = 10;
            Console.WriteLine("Before swap, a={0} and b={1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap , a={0} and b={1}",a,b);
            p = "Hello";
            q = "World";
            Console.WriteLine("Before swap p={0} and q={1}",p,q);
            Swap(ref p, ref q);
            Console.WriteLine("After swap p={0} and q={1}",p,q);
        }

        static void Swap<T> (ref T x, ref T y)
        {
            T temp;
            temp = x;
            x= y;
            y= temp;
        }
    }
}