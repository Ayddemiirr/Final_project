using market_app.enums;
using market_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMarketableForProducts
{
    public List<Product> GetProducts();
    public void AddProduct(string name, double price, int count, Category category);
    public void UpdateProduct(string name, int id, int count, double price, Category category);
    public List<Product> ShowProductInCategory(Category categoryname);
    public List<Product> ShowProductByAmountRange(double minamount, double maxamount);
    public List<Product> FindProductByName(string name);
    public void DeleteProduct(int id);
}
public interface IMarketableForSales 
{
    public List<Sale> GetSale();
    public void AddSale(int id, int amount, string saleitem, DateTime date);
    public void ReturnProductFromSale(int id);
    public void ShowSalesByDateRange(DateTime mindate, DateTime maxdate);
    public void ShowSalesByDate(DateTime date);
    public void ShowSalesByAmountRange(int amount);
    public void ShowSalesByID(int id);
}




