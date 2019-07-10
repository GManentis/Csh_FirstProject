using MyFirstProject.MyClasses;
using System.Collections.Generic;

namespace MyClasses
{
    public class Product
    {
        public Product( string givenName, string givenType)
        {
            this.ProductName = givenName;
            this.ProductType = givenType;
        }

        public Product(string givenName)
        {
            this.ProductName = givenName;
            this.ProductType = null;
        }

        public Product()
        {
            this.ProductName = null;
            this.ProductType = null;
        }

        private string productName;
        private string productType;
        private Manufacturer productManufacturerObject = new Manufacturer();
        public List<ProductReview> myReviews;
        public Price productPrice = new Price();
        private ProductCode myProductCode = new ProductCode();




        public Manufacturer ProductManufacturerObject
        {
            get
            {
                if (this.productManufacturerObject != null)
                {
                    return this.productManufacturerObject;
                }
                else
                {
                    return new Manufacturer();
                }
            }

            set
            {
                this.productManufacturerObject = value;
            }
        }

        public ProductCode MyProductCode
        {
            get
            {
                if (this.myProductCode != null)
                {
                    return this.myProductCode;
                }
                else
                {
                    return new ProductCode();
                }
            }

            set
            {
                this.myProductCode = value;
            }
        }



        public string ProductName
        {
            get
            {
                if (this.productName != null)
                {
                    return this.productName;
                }
                else
                {
                    return "";
                }

            }

            set
            {
                this.productName = value;
            }
        }

        public string ProductType
        {
            get
            {
                if (this.productType != null)
                {
                    return this.productType;
                }
                else
                {
                    return "";
                }

            }

            set
            {
                this.productType = value;
            }
        }
    }
}