using Assignment3.Enums;
using Assignment3.EShopContext;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.Repositories;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load repositories
            ColorRepository cr = new ColorRepository();
            FabricRepository fr = new FabricRepository();
            SizeRepository sr = new SizeRepository();
            PaymentRepository pr = new PaymentRepository();

            //shopkeeper
            //ShopKeeper Strategy 1
            IEnumerable<IVariationStrategy> ShopNormalVariation = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy(),

            };             
            //ShopKeeper Strategy2
            IEnumerable<IVariationStrategy> DiscountNormalVariation = new List<IVariationStrategy>()
            {
                new FabricVariationExpensiveStrategy()
            };

            // Creation Logic

            Console.WriteLine("Hello Client!");
            Console.WriteLine("Create TShirt");


            //Logic Color            
            Color finalColor = cr.ChooseColor();

            //Logic Fabric           
            Fabric finalFabric = fr.ChooseFabric();

            //Logic Size
            Size finalSize = sr.ChooseSize();

            //New Tshirt
            TShirt tshirt = new TShirt(finalColor, finalSize, finalFabric);    
            
            //Payment Method
            IPaymentMethod UserpaymentMethod = pr.PaymentMethod();

            //EShop
            var eshop = new EShop(); 
            eshop.SetVariation(DiscountNormalVariation);
            eshop.SetPaymentMethod(UserpaymentMethod);
            eshop.PayTShirt(tshirt);

        }
    }

    
}
