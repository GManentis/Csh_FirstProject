using System;
using System.Collections.Generic;
using System.IO;
using MyClasses;
using MyFirstProject.MyClasses;
using Newtonsoft.Json;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Insert Product Name");
            string prod_name = Console.ReadLine();
            Console.WriteLine("Insert Product Type");
            string prod_type = Console.ReadLine();

           

            Product myProduct = new Product(prod_name, prod_type);
            #endregion

            #region
            myProduct.myReviews = new List<ProductReview>();

            for (int i = 0; i < 5; i++)
            {
                double x = Convert.ToDouble(i);
                ProductReview testReview = new ProductReview();
                testReview.StarRate = x;
                myProduct.myReviews.Add(testReview);
            }
            #endregion


            #region
            myProduct.productPrice.InitPrice = 15.34;
            myProduct.productPrice.TaxRate = 25;
            #endregion

            #region
            Console.WriteLine("Insert Product Code");
            myProduct.MyProductCode.propProductCode = Console.ReadLine();
            #endregion
           
            #region
            Console.WriteLine("Insert Manufacturer");
            string asset = Console.ReadLine();
            myProduct.ProductManufacturerObject.ProductManufacturer = asset;
            #endregion
           
            
            string jsonProduct = JsonConvert.SerializeObject(myProduct, Formatting.Indented);

            string path = @"Products.json";

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(jsonProduct.ToString());
                tw.Close();
            }

            Console.WriteLine("Entry has been successfully stored!");
            Console.WriteLine(myProduct.ProductManufacturerObject.ProductManufacturer);
           
           



        }



    }
}