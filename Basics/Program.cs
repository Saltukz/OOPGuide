﻿
using Inheritance.Entities;
using Inheritance.Helper;
using Polymorphism.CashService;

public class Program
{
    public static void Main()
    {
        DiscMag discMag = new DiscMag("dergi", 10, 50);
        CashTill cashTill = new();

        cashTill.SellItem(discMag, 5);

        Console.WriteLine(discMag.Copies);

        TypeHelper.SaleType(discMag);

    }



}