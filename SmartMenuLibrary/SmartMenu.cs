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
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:..\..\MenuSpec.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
           
            // Suspend the screen.  
            
        }
        public void Activate()
        {
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Hej");
                    break;

                case "2":
                    Console.WriteLine("hej1");
                    break;

            }
        }
    }
}
