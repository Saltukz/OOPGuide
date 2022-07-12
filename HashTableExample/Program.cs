using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main()
        {
            Hashtable htable = new Hashtable();
            htable["Pizza"] = 15;
            htable["Hot Dog"] = 2;
            htable.Add("Noodles", 6);
            htable.Add("Burger", 5);
            Console.WriteLine("Price of Pizza is {0}", htable["Pizza"]);
            ICollection htKeys = htable.Keys;
            Console.WriteLine("\nFood items available are:");
            foreach(string str in htKeys)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\nPrice of different food items: ");
            foreach(DictionaryEntry de in htable)
            {
                Console.WriteLine("Price of {0} is {1}",de.Key,de.Value);

            }
            htable.Remove("Hot Dog");
            Console.WriteLine("\nPrice of food items except Hot Dog: ");
            foreach (DictionaryEntry de in htable)
            {
                Console.WriteLine("Price of {0} is {1}", de.Key, de.Value);

            }
        }
    }
}