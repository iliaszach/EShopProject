using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    class FabricVariationNormalStrategy :IVariationStrategy
    {
        private static Dictionary<Fabric, decimal> fabricvariations;
        static FabricVariationNormalStrategy()
        {
            fabricvariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASMERE,11m},
                { Fabric.COTTON,12m},
                { Fabric.LINEN,13m},
                { Fabric.POLYESTER,14m},
                { Fabric.RAYON, 15m},
                { Fabric.SILK ,17m},
                { Fabric.WOOL,18m}
            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += fabricvariations[tshirt.Fabric];
        }

       
    }
}
