using System;

class Program
{
    static void Main(string[] args)
    {
        Journal     journal = new Journal();
        int         menuUserinput = 0;

        List<string>   menu = new List<string>
            {
                "Choose one from the following ",
                "1. Wirte",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What Would You Want To Do?"
             };
        while (menuUserinput != 5)
        {
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }
            menuUserinput = int.Parse(Console.ReadLine());
        }
        }
}