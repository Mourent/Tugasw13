using System;
using System.Collections.Generic;

namespace Praktikumw12
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1. My scroll list");
            Console.WriteLine("2. Add scroll");
            Console.WriteLine("3. Search scroll");
            Console.WriteLine("4. Remove scroll");
            Console.Write("Choose what to do: ");
        }
        static void Main(string[] args)
        {
            Menu();
            int pilihMenu = Convert.ToInt32(Console.ReadLine());
            int ulang = 1;
            var scrolls = new List<string> { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (ulang == 1)
            {
                if (pilihMenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Scroll to learn list:");
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1}: {scrolls[i]}");
                    }
                }
                else if (pilihMenu == 2)
                {
                    Console.WriteLine("How many scroll to add:");
                    int tambahScroll = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue");
                    int barisBerapa = Convert.ToInt32(Console.ReadLine());
                    string[] bukuTambahan = new string[tambahScroll];
                    for (int i = 0; i < tambahScroll; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} name:");
                        bukuTambahan[i] = Console.ReadLine();
                    }
                    if (barisBerapa > scrolls.Count)
                    {
                        scrolls.InsertRange(scrolls.Count, bukuTambahan);
                    }
                    else if (barisBerapa < 1)
                    {
                        scrolls.InsertRange(0, bukuTambahan);
                    }
                    else
                    {
                        scrolls.InsertRange(barisBerapa - 1, bukuTambahan);
                    }
                }
                else if (pilihMenu == 3)
                {
                    Console.WriteLine();
                    int counter = 0;
                    Console.WriteLine("Insert scroll name: ");
                    string cariScroll = Console.ReadLine();
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        if (cariScroll.ToUpper().CompareTo(scrolls[i].ToUpper()) == 0)
                        {
                            Console.Write("Book found. Queue number: " + (i + 1));
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        Console.Write("Book not found");
                    }
                }
                else if (pilihMenu == 4)
                {
                    Console.WriteLine("Remove from list by scroll name? y/n");
                    string caraRemove = Console.ReadLine();
                    while (caraRemove != "y" && caraRemove != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again:");
                        Console.WriteLine("Remove from list by scroll name? y/n");
                        caraRemove = Console.ReadLine();
                    }
                    if (caraRemove == "y")
                    {
                        int counter1 = 0;
                        Console.WriteLine("Input scroll name: ");
                        string removeScroll = Console.ReadLine();
                        for (int i=0; i<scrolls.Count; i++)
                        {
                            if (removeScroll.ToUpper().CompareTo(scrolls[i].ToUpper()) == 0)
                            {
                                scrolls.Remove(scrolls[i]);
                                Console.Write("Book Removed!");
                                counter1++;
                            }
                        }
                        if (counter1 == 0)
                        {
                            Console.Write("Book not found");
                        }
                    }
                    else if (caraRemove == "n")
                    {
                        Console.WriteLine("Input scroll queue: ");
                        int removeScrollQueue = Convert.ToInt32(Console.ReadLine());
                        while (removeScrollQueue > scrolls.Count)
                        {
                            Console.WriteLine("Queue not found. Insert scroll queue: ");
                            removeScrollQueue = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.Remove(scrolls[removeScrollQueue - 1]);
                        Console.Write("Book Removed!");
                    }
                }
                Console.WriteLine();
                Menu();
                pilihMenu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
