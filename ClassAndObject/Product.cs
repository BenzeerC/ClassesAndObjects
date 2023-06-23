using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    //2.	Create class Product. Add fields like id, name and price.
    //Create properties for each field. Use object initializer syntax initialize the object.
    //Print product details using ToString()
    public class Product
    {
        private int productId, productPrice;
        private string productName;
        private int discountPrice;

        public Product(int productId,string productName,int productPrice)
        { 
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
        }

         

        public int ProductId
        {
            set { value = productId; }
            get { return productId; }
        }

        public string ProductName
        {
            set { value = productName; }
            get { return productName; }
        }

        public int ProductPrice
        {
            set { value = productPrice; }
            get { return productPrice; }
        }
       

        //3.Use above Product class, create Discount method & accept the discount percentage.
        //Give discount to the price & Display actual price & discounted price

        public int Discount(int price,int sellingPrice,int actualPrice)
        {
            int discount;
           // Console.WriteLine("Enter Product price:");
            //price = Math.Round(price);

            discount = price - sellingPrice  ;

            discountPrice = (discount / price) * 100;
            discountPrice = price - discountPrice;


            return discountPrice ;
            //Console.WriteLine("Discounted Price Is:"+discountprice);
        }
        public override string ToString()
        {
            return $"Product Id:{productId}\nProduct Name:{productName}\nProduct Price:{ProductPrice}\nDiscounted Price{discountPrice}";
        }

        public static void Main(string[] args)
        {
            Product product = new Product(101,"Laptop",78000);
            //product.ProductId = 101;
            //product.ProductName = "Mobile";
            //product.ProductPrice = 56000;
            product.ToString();
            Console.WriteLine(product.ToString());
            product.Discount(56000, 75000, 45000);
            Console.WriteLine(product.ToString());

        }
    }



    
}
