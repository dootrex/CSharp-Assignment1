using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MajorAssignment1
{
    class Menu
    {
        private static Regex rgx = new Regex(@"\d\d-\d\d\d\d");
        public static void PrintLogo()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*     Walmart Sales Manager      *");
            Console.WriteLine("**********************************");
        }
        public static void PrintMenuOptions()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Individual Store Statistics.");
            Console.WriteLine("2. All Stores Combined Statistics.");
            Console.WriteLine("3. Quit.");
            Console.WriteLine("Please enter your selection:");
        }
        public static void PrintCalcOptions()
        {
            Console.WriteLine("1. Get Total Sales.");
            Console.WriteLine("2. Get Monthly Sales.");
            Console.WriteLine("3. Get Holiday Sales.");
            Console.WriteLine("4. To return to Menu.");
        }
        public static void ProceedConfirmation()
        {
            Console.Write("Press return to continue.");
            Console.ReadLine();
        }
        static void AllStore(List<Store> st)
        {
            string selection;
            bool state = true;
            while (state)
            {
                Console.Clear();
                PrintLogo();
                PrintCalcOptions();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Total Sales for all stores are: " + StoreStats.TotalSales(st).ToString("C"));
                        ProceedConfirmation();
                        break;
                    case "2":
                        Console.WriteLine("Enter month for monthly");
                        string month = Console.ReadLine();
                        if (rgx.IsMatch(month))
                        {
                            Console.WriteLine("Total Monthly sales for " + month + " are: " + StoreStats.MonthlySales(st, month).ToString("C"));
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid month in MM-YYYY format");
                        }
                        ProceedConfirmation();
                        break;
                    case "3":
                        Console.WriteLine("Holiday Sales for all stores are: " + StoreStats.HolidaySales(st).ToString("C"));
                        ProceedConfirmation();
                        break;
                    case "4":
                        state = false;
                        break;
                    default:
                        Console.WriteLine("Select a valid option.");
                        ProceedConfirmation();
                        break;
                }
            }
            Console.Clear();
        }
        static void SelectStore(List<Store> st)
        {
            string selection;
            string storeNum;
            bool state = true;
            Console.Clear();
            PrintLogo();
            Console.WriteLine("Enter the store number:");
            storeNum = Console.ReadLine();
            Console.Clear();
            while (state)
            {
                Console.Clear();
                PrintLogo();
                Console.WriteLine("Selected Store: " + storeNum);
                PrintCalcOptions();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Total Sales for Store " + storeNum + " are: " + StoreStats.TotalSalesForStore(st, storeNum).ToString("C"));
                        ProceedConfirmation();
                        break;
                    case "2":
                        Console.WriteLine("Enter month for monthly sales in MM-YYYY format");
                        string month = Console.ReadLine();
                        if (rgx.IsMatch(month))
                        {
                            Console.WriteLine("Total Monthly sales during " + month + " are " + StoreStats.TotalMonthlySalesForStore(st, storeNum, month).ToString("C"));
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid month in MM-YYYY format");
                        }
                        ProceedConfirmation();
                        break;
                    case "3":
                        Console.WriteLine("Total Holiday Sales for Store " + storeNum + " are:" + StoreStats.HolidaySalesForStore(st, storeNum).ToString("C"));
                        ProceedConfirmation();
                        break;
                    case "4":
                        state = false;
                        break;
                    default:
                        Console.WriteLine("Select a valid option.");
                        ProceedConfirmation();
                        break;

                }
            }

        }
        public static void PrintMenu(List<Store> st)
        {
            string selection;
            bool state = true;
            while (state)
            {
                Console.Clear();
                PrintLogo();
                PrintMenuOptions();
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        SelectStore(st);
                        break;
                    case "2":
                        AllStore(st);
                        break;
                    case "3":
                        state = false;
                        break;
                    default:
                        Console.WriteLine("Select a valid option.");
                        ProceedConfirmation();
                        break;
                }
            }
        }
    }
}
