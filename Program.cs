using System;
using System.Collections.Generic;
using System.Linq;


namespace Week_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int itung = 0;
            int nomorQ = 0;
            List<string> newScroll = new List<string>() ;
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                Console.WriteLine("1. My Scroll List");
                Console.WriteLine("2. Add scroll");
                Console.WriteLine("3. Search scroll");
                Console.WriteLine("4. Remove scroll");
                Console.WriteLine("Choose what to do : ");
                int menu = Convert.ToInt32(Console.ReadLine());                
                if (menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Scroll to learn list :");
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        Console.WriteLine("Scroll " + (i + 1) + " : " + scrolls[i]);
                    }
                    Console.WriteLine();
                }
                if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many scroll to add:");
                    int tambahScroll = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue?");
                    int queue = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < tambahScroll; i++)
                    {
                        Console.WriteLine("Scroll " + (i + 1) + " name:");
                        newScroll.Add(Console.ReadLine());                        
                    }
                    if(queue < 1)
                    {
                        queue = 0;
                    }
                    else if(queue > scrolls.Count)
                    {
                        queue = scrolls.Count;
                    }
                    itung = -1;
                    foreach(var scroll in newScroll)
                    {
                        scrolls.Insert(queue+itung, scroll);
                        itung++;
                    }
                    newScroll.Clear();                                        
                    Console.WriteLine();
                }
                if(menu == 3)
                {
                    Console.Clear();
                    nomorQ = 0;
                    Console.WriteLine("Insert scroll name:");
                    string cariScroll = Console.ReadLine();                    
                    if (scrolls.Contains(cariScroll, StringComparer.OrdinalIgnoreCase))
                    {
                        newScroll = scrolls.ConvertAll(d => d.ToUpper());                        
                        nomorQ = newScroll.IndexOf(cariScroll.ToUpper());
                        Console.WriteLine($"Book found. Queue number: {nomorQ+1}");
                    }
                    else
                        Console.WriteLine("Book not found");
                    newScroll.Clear();
                    Console.WriteLine();                    
                }
                if(menu == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Remove from list by scroll name? Y/N");
                    string remove = Console.ReadLine();
                    while(remove != "y" && remove != "Y" && remove != "N" && remove != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again");
                        Console.WriteLine("Remove from list by scroll name? Y/N");
                        remove = Console.ReadLine();
                    }
                    if(remove == "y" || remove == "Y")
                    {
                        itung = 0;
                        Console.WriteLine("input scroll name:");
                        string bukuIlang = Console.ReadLine();
                        for (int i = 0; i < scrolls.Count; i++)
                        {                            
                            if (bukuIlang.ToUpper() == scrolls[i].ToUpper())
                            {                               
                                scrolls.Remove(scrolls[i]);
                                Console.WriteLine("Book Removed!");
                            }
                            else
                            {
                                itung++;
                                if(itung > scrolls.Count - 1)
                                    Console.WriteLine("Book not found");
                            }                                
                        }
                        Console.WriteLine();
                    }
                    if(remove == "n" || remove == "N")
                    {
                        Console.WriteLine("input scroll queue:");
                        int queueIlang = Convert.ToInt32(Console.ReadLine());
                        while(queueIlang < 1 && queueIlang > scrolls.Count())
                        {
                            Console.WriteLine("Queue not found. insert scroll queue:");
                            queueIlang = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.RemoveAt(queueIlang-1);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
