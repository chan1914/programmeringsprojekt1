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
        string[] danskText;
        string[] englishText;
        string[] cleanDanskText;
        int[] callId;
        public void LoadMenu(string path)
        {
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
            danskText = text.Take(text.Length / 2).ToArray();
            englishText = text.Skip(text.Length / 2).ToArray();

            cleanDanskText = danskText.Take(";").ToArray();
            callId = danskText.Skip(";").ToArray();

            /*
            int[] callId = new int[text.Length];
            string[] danskTekstLinjer = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                string[] separateInput = danskText.Split();
                danskTekstLinjer[i] = separateInput[0];
                callId[i] = int.Parse(separateInput[1]);
            }
            */

            Console.WriteLine("SmartMenu");
            Console.WriteLine("Vælg sprog");
            Console.WriteLine("1 dansk");
            Console.WriteLine("2 engelsk");
            
            
            
            
        }


        public void Activate()
        {

            ConsoleKeyInfo userinput;
            string selection = Console.ReadLine();
           
            
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    for (int i = 0; i < danskText.Length; i++)
                    {
                        Console.WriteLine(danskText[i]);
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
                        Console.WriteLine("hansenis");
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
                    for (int i = 0; i < englishText.Length; i++)
                    {
                        Console.WriteLine(englishText[i]);
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
                        Console.WriteLine("hansenis");
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


        
    


    