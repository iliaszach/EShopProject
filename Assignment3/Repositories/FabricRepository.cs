using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories
{
    public class FabricRepository
    {
        public Fabric ChooseFabric() 
        {
            Console.WriteLine("Choose Fabric");
            int fabricInput;
            Fabric finalFabric;


            var fabrics = Enum.GetNames(typeof(Fabric));
            for (int i = 0; i < fabrics.Length; i++)
            {
                Console.WriteLine($"{i,-5}{fabrics[i]}");
            }
            fabricInput = Convert.ToInt32(Console.ReadLine());
            finalFabric = (Fabric)fabricInput;
            Console.WriteLine(finalFabric);
            return finalFabric;
        }
    }
}
