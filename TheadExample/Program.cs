namespace ThreadExample
{
    class Program
    {
        static void Main()
        {
            ThreadStart deligobj = new ThreadStart(ThreadCode);
            Thread childThread = new Thread(deligobj);
            childThread.Start();
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("This is the main thread: {0}",i);
                Thread.Sleep(1000);
            }
        }

        static void ThreadCode()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("This is child thread: {0}", i);
                Thread.Sleep(500);
            }
        }
    }
}