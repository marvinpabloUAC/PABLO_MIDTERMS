using PABLO_MIDTERMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PABLO_MIDTERMS.Controllers
{
    public class POSController : ApiController
    {
        static List<product> collections = new List<product>();

        public POSController()//ENLIST ALL PRODUCTS
        {
            if (collections.Count < 1)
            {
                product phone1 = new product();//LIST OF NEW CELLPHONE CATEGORY
                phone1.ProductID = 13;
                phone1.ProductCode = 0;
                phone1.ProductName = "IPHONE 13";
                phone1.Description = "New featured phone camera and Faster Chipset with 5G capabilities";
                phone1.CategoryID = 1;
                phone1.Color = "Blue";
                phone1.Size = 22;
                phone1.Price = 52555;
                collections.Add(phone1);

                product phone2 = new product();
                phone2.ProductID = 132;
                phone2.ProductCode = 1;
                phone2.ProductName = "IPHONE 13 PRO";
                phone2.Description = "Same size as the 13 with triple camera and faster LCD";
                phone2.CategoryID = 2;
                phone2.Color = "Gold";
                phone2.Size = 20;
                phone2.Price = 54222;
                collections.Add(phone2);


                product phone3 = new product();
                phone3.ProductID = 134;
                phone3.ProductCode = 2;
                phone3.ProductName = "IPHONE 13 PRO MAX";
                phone3.Description = "Bigger phone and with better camera and its latest feature that is cinematic view";
                phone3.CategoryID = 3;
                phone3.Color = "Blue";
                phone3.Size = 16;
                phone3.Price = 67433;
                collections.Add(phone3);

                product phone4 = new product();//Lists of products for SAMSUNG LINE CATEGORY
                phone4.ProductID = 522;
                phone4.ProductCode = 3;
                phone4.ProductName = "Samsung Galaxy S22";
                phone4.Description = "Newest Phone, with triple camera and wider lens";
                phone4.CategoryID = 4;
                phone4.Color = "Blue";
                phone4.Size = 16;
                phone4.Price = 65343;
                collections.Add(phone4);

                product phone5 = new product();
                phone5.ProductID = 5224;
                phone5.ProductCode = 4;
                phone5.ProductName = "Samsung Galaxy S22 plus";
                phone5.Description = "Triple camera with a bigger screen than the S22";
                phone5.CategoryID = 5;
                phone5.Color = "Blue";
                phone5.Size = 16;
                phone5.Price = 74632;
                collections.Add(phone5);

                product phone6 = new product();
                phone6.ProductID = 5221;
                phone6.ProductCode = 5;
                phone6.ProductName = "Samsung Galaxy S22 Ultra";
                phone6.Description = "The biggest phone in the line up with a stylus pen like the note series.";
                phone6.CategoryID = 6;
                phone6.Color = "Blue";
                phone6.Size = 16;
                phone6.Price = 75000;
                collections.Add(phone6);

            }
        }


        //GET,POST,PUT,DELETE

        public List<product> Get()//Shows List of all Products
        {
            return collections;
        }

        public product Get(int index)//Shows specific product base on given index
        {
            return collections[index];
        }

        public product Post(int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Adds product to list
        {
            product P = new product();
            P.ProductID = ProductID;
            P.ProductCode = ProductCode;
            P.ProductName = ProductName;
            P.Description = Description;
            P.CategoryID = CategoryID;
            P.Color = Color;
            P.Size = Size;
            P.Price = Price;
            collections.Add(P);
            return P;

        }
        public product Put(int index, int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Updates info of specific product to list
        {
            var P = collections[index];
            P.ProductID = ProductID;
            P.ProductCode = ProductCode;
            P.ProductName = ProductName;
            P.Description = Description;
            P.CategoryID = CategoryID;
            P.Color = Color;
            P.Size = Size;
            P.Price = Price;
            collections.Add(P);
            return P;
        }

        public string Delete(int index)//Delete Product in List
        {
            collections.RemoveAt(index);
            return "Successfully Deleted";
        }

    }
}
