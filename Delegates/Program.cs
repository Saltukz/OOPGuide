namespace Delegates
{
    class Program
    {
        delegate int Calculate(int x, int y);
        static void Main()
        {
            Shapes shp = new Shapes();

            Calculate r = new Calculate(shp.Rect);

            if(r.Target == shp)
            {
                Console.WriteLine("Method been reference is: {0}", r.Method);
                Console.WriteLine("Area of rectangle is " + r(5, 6));
            }
        }


    }

}


