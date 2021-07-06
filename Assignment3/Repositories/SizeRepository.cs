using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories
{
    public class SizeRepository
    {
        public Size ChooseSize()
        {
            Console.WriteLine("Choose Size");
            int sizeInput;
            Size finalSize;
            var sizes = Enum.GetNames(typeof(Size));
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"{i,-5}{sizes[i]}");
            }
            sizeInput = Convert.ToInt32(Console.ReadLine());
            finalSize = (Size)sizeInput;
            Console.WriteLine(finalSize);
            return finalSize;
        }
    }
}
