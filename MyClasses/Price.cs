namespace MyFirstProject.MyClasses
{
    public class Price
    {

        public Price()
        {
            this.InitPrice = 0;
            this.TaxRate = 0;
        }

        private double initPrice;
        private double taxRate;






        public double InitPrice
        {
            get
            {
                return initPrice;
            }

            set
            {
                if (value > 0 && value < 100)
                {
                    this.initPrice = value;
                }
                else
                {
                    this.initPrice = 0;
                }
            }

        }

        public double WholeScalePrice
        {
            get
            {
                if (this.initPrice != 0)
                {
                    return ((initPrice * 3) / 100) + initPrice;
                }
                else
                {
                    return 0.0;
                }
            }

        }

        public double TaxRate
        {
            get
            {
               if(this.taxRate != 0)
               {
                    return this.taxRate;

                }
               else
               {
                    return 23;
               }

            }

            set
            {
                this.taxRate = value;
            }



        }

        public double RetailPrice
        {
            get
            {
                if (this.initPrice != 0 &&this.taxRate !=0)
                {
                    return (((initPrice * 5) / 100) + initPrice)*this.taxRate/100 + (((initPrice * 5) / 100) + initPrice);
                }
                else
                {
                    return 0.0;
                }
            }

        }
    }
}
