﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Article
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int ArticleNr { get; set; }
        public int ShopNr { get; set; }
        public string ShopName { get; set; } // for ease of display
        public string ArticleName { get; set; }
        public double Price { get; set; }
        public int Available { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////

        // Various constructors to initialize object with
        // Depending on the usage, the appropriate constructor will be chosen

        /**
         * Constructor with full variables
         */
        public Article(int shopNr, string shopName, int articleNr, string articleName, double price, int available)
        {
            this.ShopNr = shopNr;
            this.ShopName = shopName;
            this.ArticleNr = articleNr;
            this.ArticleName = articleName;
            this.Price = price;
            this.Available = available;
        }
        
        /**
         * Constructors without ShopName and Img
         */
        public Article(int shopNr, int articleNr, string articleName, double price, int available)
        {
            this.ShopNr = shopNr;
            this.ArticleNr = articleNr;
            this.ArticleName = articleName;
            this.Price = price;
            this.Available = available;
        }

        /**
         * Simplest constructors to display items
         */
        public Article(string shopName, int articleNr, string articleName)
        {
            this.ShopName = shopName;
            this.ArticleNr = articleNr;
            this.ArticleName = articleName;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        public override string ToString()
        {
            return "Article nr. " + ArticleNr + ": " + ArticleName;
        }
    }
}
 