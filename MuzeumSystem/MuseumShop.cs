using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class MuseumShop
    {
        /// <summary>
        /// Museum shop offer some products
        /// </summary>
        private List<string> products { get; set; }
        /// <summary>
        /// Each product has price
        /// </summary>
        private List<int> priceForProduct { get; set; } 
        public MuseumShop()
        {
            products = new List<string>() {"Postcard", "Paperweight", "Pen", "T-shirt"};
            priceForProduct = new List<int>() { 15, 35, 20, 100 };
        }
        /// <summary>
        /// Shop offer is visible visitors after exhibition
        /// </summary>
        /// <returns></returns>
        public string ShopOffer()
        {
            string offer = "Muzeum shop \n";
            for (int i = 0; i < products.Count; i++)
            {
                offer += string.Format("{0}.{1} ({2} Kč)\n",i + 1, products[i], priceForProduct[i]);
            }
            return offer;
        }
        /// <summary>
        /// If visitor is decided buy something, we have to give him option to pay it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string BuyProduct(string product)
        {
            int insertedMoney = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (product.Equals(products[i]))
                {
                    while (insertedMoney < priceForProduct[i])
                    {
                        Console.Write("Insert money: ");
                        insertedMoney += int.Parse(Console.ReadLine());
                    }
                    return string.Format("You bought: {0}",products[i]);
                }    

            }
            return string.Format("You didn't bought it");
        }
    }
}
