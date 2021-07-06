using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    class FabricVariationExpensiveStrategy:IVariationStrategy
    {
        private static Dictionary<Fabric, decimal> fabricvariations;
        static FabricVariationExpensiveStrategy()
        {
            fabricvariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASMERE,100m},
                { Fabric.COTTON,120m},
                { Fabric.LINEN,130m},
                { Fabric.POLYESTER,140m},
                { Fabric.RAYON, 150m},
                { Fabric.SILK ,170m},
                { Fabric.WOOL,180m}
            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += fabricvariations[tshirt.Fabric];
        }        
    }
}
