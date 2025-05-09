using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7
{
    public class Product
    {
        //List of products 
        List<Product> products = new List<Product>();

        //Properties needed for this class PublicID, ProductName, Price

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Price { get; set; }





        public Product()
        {
            ProductId = productId;

            ProductName = ProductName;

            Price = Price;

            //Menu for the user to select from 
            Console.WriteLine("Welcome to the online store! Pick the an option from the menu");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2.Remove a product");
            Console.WriteLine("3. Calculate a total price");
            Console.WriteLine("4. Exit");
            //User choice 
            int choice = Convert.ToInt32(Console.ReadLine());



            //switch case to go through the options 
            switch (choice)
            {
                case 1:
                    AddProduct(new Product());
                    break;

                case 2:
                    RemoveProduct(new Product());
                    break;

                case 3:
                    CalculateTotalPrice(); 
                    break;

                case 4:
                    
                break;




            }
        }



        public void ShoppingCart()
        {


        }

        public void AddProduct(Product product)
        {
            Console.WriteLine("Enter a product you'd like to add!");
            string user = Convert.ToString(product);
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Console.WriteLine("Enter the product you would like to remove");
            string user = Convert.ToString(product);
            products.Remove(product);

        }
        public void CalculateTotalPrice()
        {

        }
    }


    public class Program
    {
        public void Main()
        {


            }
        }
    }
}