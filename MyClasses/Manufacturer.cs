using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyClasses
{
    public class Manufacturer
    {
        public Manufacturer(string manufacturer)
        {
            this.ProductManufacturer = manufacturer;
        }

        public Manufacturer()
        {
            this.ProductManufacturer = null;
        }

        private string productManufacturer;

        public string ProductManufacturer
        {
            get
            {
                return this.productManufacturer;
            }
            set
            {
                this.productManufacturer = value;
            }
        }


    }
}
