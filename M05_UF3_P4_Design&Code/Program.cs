using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace M05_UF3_P4_Design_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string selection;
            show_menu();
            selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Orders.add_product();
                    break;


     


            }
            
        }

        public static void show_menu()
        {
            Console.WriteLine("choose an option: ");
            Console.WriteLine("1 - Add product");
            Console.WriteLine("2 - Remove product");
            Console.WriteLine("3 - View cart");
            Console.WriteLine("0 - Exit");
        }
        
    }
}

