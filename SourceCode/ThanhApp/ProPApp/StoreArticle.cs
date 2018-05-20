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
        public int StoreNr { get; set; }
        public int ArticleNr { get; set; }
        public string ArticleName { get; set; }
        public decimal UnitPrice { get; set; } 
        public int InStock { get; set; }
        public string Img { get; set; } // will come to use later

        // Constructors
        public StoreArticle(int storenr, int nr, string name, decimal price, int stock, string img)
        {
            this.StoreNr = storenr;
            this.ArticleNr = nr;
            this.ArticleName = name;
            this.UnitPrice = price;
            this.InStock = stock;
            this.Img = img;
        }

        public StoreArticle(int storenr, int nr, string name)
        {
            this.StoreNr = storenr;
            this.ArticleNr = nr;
            this.ArticleName = name;
        }


        // Methods
        public override string ToString()
        {
            return "Article #" + this.ArticleNr + " - " + this.ArticleName + " - $" + this.UnitPrice + " - In stock: " + this.InStock;
        }
    }
}
