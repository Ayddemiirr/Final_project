using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace market_app.helpers
{
    public class SubMenu
    {
        public static void ProductSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Show all products");
                Console.WriteLine("5. Show products by category");
                Console.WriteLine("6. Show products by amount range");
                Console.WriteLine("7. Find product by name");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

         

        




         public static void SaleSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add new sale");
                Console.WriteLine("2. Return product");
                Console.WriteLine("3. Remove sale");
                Console.WriteLine("4. Show all sales");
                Console.WriteLine("5. Show sales by mindate and maxdate range");
                Console.WriteLine("6. Show sales by amount range");
                Console.WriteLine("7. Show sales by date range");
                Console.WriteLine("8. Show sales by ID");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }






        