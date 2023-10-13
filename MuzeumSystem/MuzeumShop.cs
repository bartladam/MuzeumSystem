﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class MuzeumShop
    {
        private List<string> products { get; set; }
        private List<int> priceForProduct { get; set; } 
        public MuzeumShop()
        {
            products = new List<string>() {"Postcard", "Paperweight", "Pen", "T-shirt"};
            priceForProduct = new List<int>() { 15, 35, 20, 100 };
        }
        public string ShopOffer()
        {
            string offer = "";
            for (int i = 0; i < products.Count; i++)
            {
                offer += string.Format("{0}.{1} ({2})\n",i, products[i], priceForProduct[i]);
            }
            return offer;
        }
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
