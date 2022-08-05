using _002_bootle_deposits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _002_bootle_deposits_console
{
    public static class ReportBill
    {

        static string label_head_number_container = "";
        static string label_head_price_container = "";
        static string label_head_refund_container = "";
        static string label_number_conatiner1L = "";
        static string label_number_conatinerOL = "";
        static string label_price_container1L = "";
        static string label_price_containerOL = "";
        static string label_refund_container1L = "";
        static string label_refund_containerOL = "";
        static string label_refund_total = "";

        public static string lang_system = CultureInfo.CurrentUICulture.ToString(); 
        static byte screen_charwidth = 60;
        static String line_delim = new string('-', screen_charwidth);
        static ReportBill() {
            //Console.WriteLine("constructor static");
            Translate("de");
        }

        private static void Translate(string lang_selection = "")
        {

            Console.WriteLine("TRANSLATE ...");

            if (lang_selection == "")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang_system);
            }else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang_selection);

            }

            label_head_number_container = Properties.lang.lang.label_head_number_container;
            label_head_price_container =  Properties.lang.lang.label_head_price_container;
            label_head_refund_container = Properties.lang.lang.label_head_refund_container;
            label_number_conatiner1L =  Properties.lang.lang.label_number_conatiner1L;
            label_number_conatinerOL = Properties.lang.lang.label_number_conatinerOL;
            label_price_container1L = Properties.lang.lang.label_price_container1L;
            label_price_containerOL = Properties.lang.lang.label_price_containerOL;
            label_refund_container1L = Properties.lang.lang.label_refund_container1L;
            label_refund_containerOL = Properties.lang.lang.label_refund_containerOL;
            label_refund_total = Properties.lang.lang.label_refund_total;
            
        }

        public static void Print(BootleOneLiter bootleOneLiter, BootleOverLiter bootleOverLiter, Bill bill) {

            const SByte COLUM1_WIDTH = -49;
            const SByte COLUM2_WIDTH = 7;

            Console.WriteLine();
            Console.WriteLine(line_delim);
            Console.WriteLine(label_head_number_container);
            Console.WriteLine(line_delim);


            Console.WriteLine($"{label_number_conatiner1L,COLUM1_WIDTH} {bill.ContainerOneLiter,COLUM2_WIDTH} PZ");
            Console.WriteLine($"{label_number_conatinerOL,COLUM1_WIDTH} {bill.ContainerOverLiter,COLUM2_WIDTH} PZ");

            Console.WriteLine(line_delim);



            Console.WriteLine();
            Console.WriteLine(line_delim);
            Console.WriteLine(label_head_price_container);
            Console.WriteLine(line_delim);

            Console.WriteLine($"{label_price_container1L,COLUM1_WIDTH} {bootleOneLiter.Deposits_Price,COLUM2_WIDTH:N2} EU");
            Console.WriteLine($"{label_price_containerOL,COLUM1_WIDTH} {bootleOverLiter.Deposits_Price,COLUM2_WIDTH:N2} EU");

            Console.WriteLine(line_delim);

            Console.WriteLine();
            Console.WriteLine(line_delim);
            Console.WriteLine(label_head_refund_container);
            Console.WriteLine(line_delim);

            Console.WriteLine($"{label_refund_container1L,COLUM1_WIDTH} {bill.RefundContainerOneLiter(bootleOneLiter.Deposits_Price),COLUM2_WIDTH:N2} EU");
            Console.WriteLine($"{label_refund_containerOL,COLUM1_WIDTH} {bill.RefundContainerOverLiter(bootleOverLiter.Deposits_Price),COLUM2_WIDTH:N2} EU");
            Console.WriteLine(line_delim);
            double total_refund = bill.TotalRefundConatiner(bootleOneLiter.Deposits_Price, bootleOverLiter.Deposits_Price);
            Console.WriteLine($"{label_refund_total,COLUM1_WIDTH} {total_refund,COLUM2_WIDTH:N2} EU");

        }


    }
}
