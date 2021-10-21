using System.IO;
using System.Collections.Generic;
using MajorAssignment1;

class Program
{
    static void Main(string[] args)
    {
        //Read from a file and store in a list of Stores
        StreamReader reader = new StreamReader("../../../Walmart_Store_Data.csv");
        List<Store> store = new List<Store>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            Store foo = new Store() { store = values[0], date = values[1], weeklySale = values[2], holiday = values[3] };
            store.Add(foo);
        }
        Menu.PrintMenu(store);
    }
}