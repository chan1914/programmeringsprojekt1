using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

            
            string input = Console.ReadLine();
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");

            string name = (Console.ReadLine());
            Console.WriteLine("Is " + name + " ok?");
            Console.WriteLine("\n(Y)es\n(N)o");
            string ansys = Console.ReadKey();

            switch (input)
            {
                case "d":
                    Console.Clear();
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(text[i]);
                    }
                    
                    if (ansys = ConsoleKey.Y)
                        Console.Clear();
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter letters only");
                    }
                    break;
                    


                    /*
                        case "2":
                            Console.Clear();
                            for (int i = 12; i < 18; i++)
                            {
                                Console.WriteLine(text[i]);
                            }
                            break;

                    */


            }
        }
    }
}


        
    


    