using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApp
{
    class Store
    {
        // FIELDS + PROPERTIES
        // non-changable fields
        public int StoreNr { get; set; }
        public string StoreName { get; set; }
        public string LocationName { get; set; }

        // Constructors
        public Store(int nr, string name, string loc)
        {
            this.StoreNr = nr;
            this.StoreName = name;
            this.LocationName = loc;
        }

        // Methods
        public override string ToString()
        {
            return "Store #" + this.StoreNr + " - " + this.StoreName + " located at " + this.LocationName;
        }
    }
}
