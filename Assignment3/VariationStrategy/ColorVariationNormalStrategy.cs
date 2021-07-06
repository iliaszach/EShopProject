using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    public class ColorVariationNormalStrategy:IVariationStrategy
    {
        private static Dictionary<Color, decimal> colorvariations;
        static ColorVariationNormalStrategy()
        {
            colorvariations = new Dictionary<Color, decimal>()
            {
                { Color.BLUE,1m},
                { Color.GREEN,2m},
                { Color.INDIGO,3m},
                { Color.ORANGE,4m},
                { Color.RED,5m},
                { Color.VIOLET,7m},
                { Color.YELLOW,8m}
            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += colorvariations[tshirt.Color];
        }
    }
}
