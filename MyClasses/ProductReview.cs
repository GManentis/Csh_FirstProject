using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MyClasses
{
    public class ProductReview
    {


        public ProductReview(double starz)
        {

            this.StarRate = starz;
        }
     
        public ProductReview()
        {
            this.StarRate = 0;
        }

        
        private double starRating;

        public double StarRate
        {
            get
            {
               return this.starRating;
            }
                
            set
            {
                if (value >= 0 && value <= 5)
                {
                    this.starRating = value;
                }
                else
                {
                    Console.WriteLine("Invalid entry!Rating will be set to 0");
                    this.starRating = 0;
                }
            }
                
        }

        public double CommonRating
        {
            get
            {
                return this.starRating*2;
            }


        }


    }
}
