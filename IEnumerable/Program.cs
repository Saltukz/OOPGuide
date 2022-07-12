namespace IEnumerableExample
{
    public class Program
    {
        static void Main()
        {
            //foreach(string str in GetDemoEnumerable())
            //{
            //    Console.WriteLine(str);
            //}

            int[] data = { 1, 2, 3,4,5 };
            SingleDim arry = new SingleDim(data);
            Console.WriteLine("array elements are ");

            foreach(int item in arry)
            {
                Console.WriteLine(item);
            }


        }

        static IEnumerable<string> GetDemoEnumerable()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i.ToString();

            }
            yield return "numbers over";
        }
    }

   


}