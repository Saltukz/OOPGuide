namespace TryCatchExample
{
    class Program
    {
        static void Main()
        {
            int x = 10,y=0,z= 0;
            int[] p = new int[3];

            try
            {
                z = x / y;
                Console.WriteLine("Result of dividing {0} by {1} is {2}",x,y,z);

            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception has occurred", ex);

            }
            try
            {
                p[3] = 23;
                Console.WriteLine("Array element is {0}", p[3]);
            }catch(System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception has occurred - ", ex);
            }
            finally
            {
                Console.WriteLine("This is Finally");
            }
        }
    }
}