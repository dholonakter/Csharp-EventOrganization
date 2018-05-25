using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Order
    {
        /// <summary>
        /// This class holds information about an order
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int OrderNr { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public Shop Shop { get; set; }
        public int VisitorNr { get; set; }
        public List<Article> Articles { get; set; }
        public List<int> Quantity { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Order(Shop originShop)
        {
            Shop = originShop;
            Articles = new List<Article>();
            Quantity = new List<int>();
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        /// <summary>
        /// Export order's information as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Articles.Count != 0)
            {
                string info = "--- WELCOME TO " + Shop.ShopName.ToUpper() + " ---\n";
                info += "YOUR ORDER: \n";

                if (OrderDate != null && OrderTime != null)
                {
                    info += "Purchased at: " + OrderDate + " " + OrderTime + "\n\n";
                }

                for (int i = 0; i < Articles.Count; i++)
                {
                    info += Articles[i].ArticleName
                        + "\t - Quantity: " + Quantity[i]
                        + "\t - Subtotal:" + Articles[i].Price * Quantity[i] + "\n";
                }

                info += "\nTOTAL: " + GetSum() + "\n";

                if (OrderDate != null & OrderTime != null)
                {
                    info += "\nTHANK YOU FOR YOUR PURCHASE";
                }

                return info;
            }

            return "NO ARTICLES IN ORDER";
        }

        /// <summary>
        /// Add an article by n quantity
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nr"></param>
        public void AddArticle(Article a, int nr)
        {
            if (Articles.Count != 0)
            {
                for (int i = 0; i < Articles.Count; i++)
                {
                    if (Articles[i] == a)
                    {
                        Quantity[i] += nr;
                        return;
                    }
                }
            }
            Articles.Add(a);
            Quantity.Add(nr);
        }

        /// <summary>
        /// Remove an article by n quantity
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nr"></param>
        public void RemoveArticle(Article a, int nr)
        {
            for (int i = 0; i < Articles.Count; i++)
            {
                if (Articles[i] == a)
                {
                    if (Quantity[i] - nr <= 0)
                    {
                        Quantity.RemoveAt(i);
                        Articles.RemoveAt(i);
                    }
                    else
                    {
                        Quantity[i] -= nr;
                    }
                    return;
                }
            }
        }

        /// <summary>
        /// Get total sum of an order
        /// </summary>
        /// <returns></returns>
        public double GetSum()
        {
            double sum = 0;

            if (Articles.Count != 0)
            {
                for (int i = 0; i < Articles.Count; i++)
                {
                    sum += Articles[i].Price * Quantity[i];
                }
                return sum;
            }

            return 0;
        }
    }
}
