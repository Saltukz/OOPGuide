class Program
{
    public static void Main()
    {
        int u = 50, v = 8;
        Console.WriteLine("Before calling method. Value of u={0} and v={1}", u, v);
        int z = getrect(ref u, ref v);
        Console.WriteLine("Area of rectangle is {0}", z);
        Console.WriteLine("After calling method. Value of u={0} and v={1}", u, v);

        int y;
        getrectOut(u, v, out y);
        Console.WriteLine("out method sonuc = {0}",y);

        int multiX, multiY;
        float multiFloat;

        multipleReturn(u, v,out multiX, out multiY, out multiFloat);

        Console.WriteLine("multiple return sonucları : {0},{1},{2}",multiX,multiY,multiFloat);

    }

    static int getrect(ref int l, ref int b)
    {
        int a = l * b;
        l = 10;
        b = 20;
        return a;
    }

    static void getrectOut(int l , int b, out int a)
    {
        a = l * b;
    }

    static void multipleReturn(int l , int b ,out int c , out int d, out float e)
    {
        c = l + b;
        d = l * b;
        e = (float)l / b;
    }
}