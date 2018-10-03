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
        private bool firstArray;

        public void LoadMenu(string path)
        {
            Console.WriteLine("SmartMenu");
            Console.WriteLine("Vælg sprog");
            Console.WriteLine("1 dansk");
            Console.WriteLine("2 engelsk");
            
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
            for (int i = 0; i < text.Length; i++)
            {
                string[] firstArray = text.Take(text.Length / 2).ToArray();

            }
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
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine(text[i]);
                    }
                    
                    userinput = Console.ReadKey();
                    if (userinput.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine(firstArray);
                    }
                    else if (userinput.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine(Functions.DoThis());
                    }
                    else if (userinput.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine("hansen_is");
                    }
                    else if (userinput.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine("gustav");
                    }
                    else if (userinput.Key == ConsoleKey.D0)
                    {
                        Console.Clear();
                        Environment.Exit(0); 
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("tryk 1-4 eller 0 for at afslutte");
                    }

                    break;

                   
                case "2":
                    Console.Clear();
                    for (int i = 6; i < 12; i++)
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
                        Console.Clear();
                        Console.WriteLine(Functions.DoThis());
                    }
                    else if (userinput.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine("hansen_is");
                    }
                    else if (userinput.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine("gustav");
                    }
                    else if (userinput.Key == ConsoleKey.D0)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("press 1-4 or 0 to exit");
                    }
                    break;

                    


            }
        }
    }
}


        
    


    