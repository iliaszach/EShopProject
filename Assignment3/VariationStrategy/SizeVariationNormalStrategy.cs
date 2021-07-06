using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    class SizeVariationNormalStrategy:IVariationStrategy
    {
        private static Dictionary<Size, decimal> sizecvariations;
        static SizeVariationNormalStrategy()
        {
            sizecvariations = new Dictionary<Size, decimal>()
            {
                { Size.XS,7m},
                { Size.S,11m},
                { Size.M,12m},
                { Size.L,13m},
                { Size.XL,14m},
                { Size.XXL, 15m},
                { Size.XXXL,17m},
                
            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += sizecvariations[tshirt.Size];
        }
    }
}
