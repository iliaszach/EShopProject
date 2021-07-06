using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories
{
    public class ColorRepository
    {
        public Color ChooseColor()
        {
            Console.WriteLine("Choose Color");
            int colorInput;
            Color finalColor;


            var colors = Enum.GetNames(typeof(Color));
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{i,-5}{colors[i]}");
            }
            colorInput = Convert.ToInt32(Console.ReadLine());
            finalColor = (Color)colorInput;
            Console.WriteLine(finalColor);
            return finalColor;

        }
    }
}
