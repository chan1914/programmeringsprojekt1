using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;


namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        
        public void LoadMenu(string path)
        {
            Console.WriteLine("SmartMenu");
            Console.WriteLine("Vælg sprog");
            Console.WriteLine("1 dansk");
            Console.WriteLine("2 engelsk");
            /*
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(text[i]);
            }

            for (int i = 12; i < 18; i++)
            {
                Console.WriteLine(text[i]);
            }

            */
        }


        public void Activate()
        {

            ConsoleKeyInfo userinput;
            string selection = Console.ReadLine();
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");

            switch (selection)
            {
                case "1":
                    Console.Clear();
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(text[i]);
                    }
                    userinput = Console.ReadKey();
                    if (userinput.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine(Functions.DoThat());
                    }
                    else if (userinput.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine(Functions.DoThis());
                    }
                    else if (userinput.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine();
                    }
                    else if (userinput.Key == ConsoleKey.D4)
                    {
                        Console.WriteLine();
                    }
                    else if (userinput.Key == ConsoleKey.D0)
                    { 
                        
                    }
                    else
                    {
                        Console.WriteLine("tryk 1-4 eller 0 for at afslutte");
                    }

                    break;

                   
                case "2":
                    Console.Clear();
                    for (int i = 12; i < 18; i++)
                    {
                        Console.WriteLine(text[i]);
                    }
                    break;

                    


            }
        }
    }
}


        
    


    