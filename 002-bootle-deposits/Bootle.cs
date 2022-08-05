using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_bootle_deposits
{
    public class BootleOneLiter
    {
        private double deposits_price = 0.10;

        public BootleOneLiter()
        {
            

        }

        public double Deposits_Price { 
        
            get { return deposits_price; }      
            set { deposits_price = value; }
        }


    }

    public class BootleOverLiter
    {
        private double deposits_price = 0.25;

        public BootleOverLiter()
        {
            

        }

        public double Deposits_Price
        {

            get { return deposits_price; }
            set { deposits_price = value; }
        }

    }







}
