using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApp
{
    class StoreArticle
    {
        // FIELDS + PROPERTIES
        // non-changable fields
        public int ArticleNr { get; set; }
        public string ArticleName { get; set; }
        public decimal UnitPrice { get; set; } 
        public int InStock { get; set; }
        // Constructors
        public StoreArticle(int nr, string name, decimal price, int stock)
        {
            this.ArticleNr = nr;
            this.ArticleName = name;
            this.UnitPrice = price;
            this.InStock = stock;
        }

        // Methods
        public override string ToString()
        {
            return "Article #" + this.ArticleNr + " - " + this.ArticleName + " - $" + this.UnitPrice + " - In stock: " + this.InStock;
        }
    }
}
