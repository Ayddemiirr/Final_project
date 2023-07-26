using market_app.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_app.models
{
    public class Sale : BaseEntity
    {
        private static int counter = 0;

        public Sale(int amount, string saleitem, DateTime date, Product salesProduct)
        {
            Amount = amount;
            SaleItem = saleitem;
            Date = date;
            SalesProduct = salesProduct;
            ID = counter;
            counter++;

        }
        public int Amount { get; set; }
        public string SaleItem { get; set; }
        public DateTime Date { get; set; }
        public Product SalesProduct { get; set; }
    }
}
