using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyClasses
{
    public class ProductCode
    {
        public ProductCode()
        {
            this.propProductCode = "";
        }

        private string productCode;

        public string propProductCode
        {
            get
            {
                return productCode;
            }

            set
            {
                this.productCode = value;
            }
        }


    }
}
