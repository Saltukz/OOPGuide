namespace LinqExample
{
    class Program
    {
        static void Main()
        {
            string[] fruits = { "Apple", "Grapes", "Mango", "Banana", "Pineapple" };
            IEnumerable<string> selectedFruits = from f in fruits where f.Length >= 6 orderby f select f;

            foreach(var selectedFru in selectedFruits)
            {
                Console.WriteLine(selectedFru);
            }
        }
    }
}