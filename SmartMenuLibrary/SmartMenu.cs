﻿using System;
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
        int[] callId;
        int j;




        string start = String.Join(Environment.NewLine, "SmartMenu",
            "Vælg sprog",
            "1 dansk",
            "2 engelsk");

        public void LoadMenu(string path)
        {
            Console.WriteLine(start);
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
            danskText = text.Take(text.Length / 2).ToArray();
            englishText = text.Skip(text.Length / 2).ToArray();
           

            for (int i = 0; i < danskText.Length; i++)
            {
                
                if (danskText[i].Contains(';'))
                {
                    j++;
                    string[] spliter = danskText[i].Split(';');
                    danskText[i] = spliter[0];

                }
            }

            callId = new int[j];

            for (int i = 0; i < j; i++)
            {
                callId[i] = i + 1;
            }

            

        }
        public void Activate()
        {

            ConsoleKeyInfo userinput;
            string s = Console.ReadLine();
            
            int n = int.Parse(s);

            switch (n)
            {
                case 1:
                    Console.Clear();
                    for (int i = 0; i < danskText.Length; i++)
                    {
                        Console.WriteLine(danskText[i]); 
                    }
                    for (int i = 0; i < callId.Length; i++)
                    {
                        Console.WriteLine(callId[i]);
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

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("tryk 1-4 eller 0 for at afslutte");

                            }
                    Console.WriteLine(start);
                            Activate();
                            break;




                        case 2:
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
                                
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("press 1-4 or 0 to exit");
                            }
                            Console.WriteLine(start);
                            Activate();
                            break;

                    }
                
            
        }   
    }
}


        
    


    