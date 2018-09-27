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
            string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(text[i]);
            }

            for (int i = 12; i < 18; i++)
            {
                Console.WriteLine(text[i]);
            }


        }


        public void Activate()
        {
            
            
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Hej");
                    
                    break;

                case "2":
                    Console.WriteLine("hej1");
                    break;

            }
        }
    }
}


        
    


    