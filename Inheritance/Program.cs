using Inheritance.Entities;

public class Program
{
    public static void Main()
    {
        Book book = new("insan ne ile yaşar", 123.3, 50, "tolstoy");

        Book book2 = new();

        book2.Author = "dosto";

        DiscMag discMag = new("diskli dergim", 11, 200);

        discMag.RecNewIssue("1. sayfa yok");

        Publication p = new DiscMag("diskli dergim", 11, 200);


        // DiscMag dm = new Magazine()    magazine superclass of discmag

        Console.WriteLine(discMag.currIssue);
    }

    

    
    

    
}