namespace StreamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, k;
            FileStream fp = null;

            try
            {
                fp = new FileStream(Directory.GetCurrentDirectory()+"sssaas", FileMode.Create);

            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("How many number do you want to store in the file?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers ", n);
            try
            {
                for(i = 0; i <= n; i++)
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    fp.WriteByte((byte)k);
                }
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            fp.Close();

            int t;

            FileStream fpin = null;
            try
            {
                fpin = new FileStream(Directory.GetCurrentDirectory() + "sssaas", FileMode.Open);

            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("The data in the byte file is: ");
            try
            {
                do
                {
                    t = fpin.ReadByte();
                    if (t != -1) Console.WriteLine((byte)t);

                } while (t != -1);
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            fpin.Close();
        }
    }
}