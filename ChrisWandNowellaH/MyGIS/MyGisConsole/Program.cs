using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGisBLL;

namespace MyGisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mapCanada = new Map();
            mapCanada.Name="Canada";

            Layer addl0 = new Layer();
            Layer addl1 = new Layer();
            Layer addl2 = new Layer();

            addl0.Name = "Ontario";
            addl1.Name = "Manitoba";
            addl2.Name = "Alberta";

            mapCanada.AddLayer(addl0);
            mapCanada.AddLayer(addl1);
            mapCanada.AddLayer(addl2);

            Layer manitobaByIndex= mapCanada.Layers[1];
            Console.WriteLine(manitobaByIndex.Name);

            Layer manitobaByName = mapCanada.GetLayerByName("Manitoba");
            Console.WriteLine(manitobaByName.Name);

            // write map and layer contents
            Console.WriteLine("Map: "+mapCanada.Name);
            Console.WriteLine("\t" +"Layer 0: "+ addl0.Name);
            Console.WriteLine("\t" +"Layer 1: "+ addl1.Name);
            Console.WriteLine("\t" +"Layer 2: "+ addl2.Name);

            // last line of the program
            Console.Read();

            //pass layer index that does not exist
            Layer wrongIndex;
            
            // if try step 32
            
            
                    
        }
    }
}
