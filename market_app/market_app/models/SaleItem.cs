using market_app.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_app.models
{
    public class SaleItem : BaseEntity
    {
        private static int counter = 0;
        public SaleItem(int count, string product)
        {
            Count = count;
            Product = product;
            ID = counter;
            counter++;
        }
        public int Count { get; set; }

        public string Product { get; set; }
        
        
        
}
