class Program
{
    static void Main()
    {
        Product p = new Product(10);
        p.Display();
        p.ProductEvent += new ProductDelegate(p.Display);
        p.Qty = 10;
        p.Qty = 20;

    }

    public delegate void ProductDelegate();

    public class Product
    {
        public event ProductDelegate ProductEvent;
        int qty;
        public Product(int v)
        {
            qty = v;
        }

        public int Qty
        {
            get { return qty; }
            set
            {
                if (qty == value) return;
                if(ProductEvent != null)
                {
                    qty = value;
                    ProductEvent();
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Product quantity is {0}", qty);
        }
    }
}