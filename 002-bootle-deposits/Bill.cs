using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_bootle_deposits
{
    public class Bill
    {

        #region delclaration
        private int containerOneLiter = 0;
        private int containerOverLiter = 0;

        private double refundContainerOneLiter = 0.0;
        private double refundContainerOverLiter = 0.0;
        #endregion

        public Bill(BootleOneLiter bootleOneLiter,BootleOverLiter bootleOverLiter, int numberContainerOneLiter, int numberContainerOverLiter) {
            this.ContainerOneLiter = numberContainerOneLiter;
            this.ContainerOverLiter = numberContainerOverLiter;
        }

        public int ContainerOneLiter { get => containerOneLiter; set => containerOneLiter = value; }
        public int ContainerOverLiter { get => containerOverLiter; set => containerOverLiter = value; }

        public double RefundContainerOneLiter(double price)
        {
            return price * this.ContainerOneLiter ;
        }

        public double RefundContainerOverLiter(double price)
        {
            return price * this.containerOverLiter;
        }

        public double TotalRefundConatiner(double priceOneLt, double priceOverLt) {

            return (priceOneLt * this.ContainerOneLiter) + (priceOverLt * this.containerOverLiter);

        }


    } 
}
