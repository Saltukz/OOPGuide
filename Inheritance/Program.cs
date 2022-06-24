class Program
{
    static void Main()
    {
        Book book = new("insan ne ile yaşar", 123.3, 50, "tolstoy");

        Book book2 = new();

        book2.Author = "dosto";

        Console.WriteLine(book.Author);
        Console.WriteLine(book2.Author);
    }

    class Publication
    {
        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public int Copies { get; set; }

        public Publication(string title, double price, int copies)
        {
            Title = title;
            Price = price;
            Copies = copies;
            Console.WriteLine("Selam ben parametreli publication");

        }

        public Publication()
        {
            Console.WriteLine("selam ben publication");
        }

        public void SellCopy(int quantity)
        {
            Copies -= quantity;
        }
    }

    class Book : Publication
    {
        public Book(string title, double price, int copies, string author) : base(title, price, copies)
        {
            Author = author;
        }

        public Book()
        {

        }
     

        public string Author { get; set; } = null!;

        public void OrderCopies(int quantity)
        {
            Copies += quantity;
        }
    }

    class Magazine : Publication
    {
        public Magazine(string title, double price, int copies) : base(title, price, copies)
        {
        }

        public int OrderQty { get; set; }

        public string? currIssue { get; set; }

        public void AdjustQty(int qty)
        {
            OrderQty = qty;
        }

        public void RecNewIssue(string issue)
        {
            currIssue = issue;
        }
    }
}