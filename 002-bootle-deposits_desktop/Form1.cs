using _002_bootle_deposits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _002_bootle_deposits_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Traduci(String lang_selection) 
        {
            MessageBox.Show(lang_selection);

            if (lang_selection == "")
            {
                //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang_system);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang_selection);

            }

            
            label_number_conatiner1L.Text = Properties.lang.lang.label_head_number_container;
            /*
            label_head_price_container = Properties.lang.lang.label_head_price_container;
            label_head_refund_container = Properties.lang.lang.label_head_refund_container;
            label_number_conatiner1L = Properties.lang.lang.label_number_conatiner1L;
            label_number_conatinerOL = Properties.lang.lang.label_number_conatinerOL;
            label_price_container1L = Properties.lang.lang.label_price_container1L;
            label_price_containerOL = Properties.lang.lang.label_price_containerOL;
            label_refund_container1L = Properties.lang.lang.label_refund_container1L;
            label_refund_containerOL = Properties.lang.lang.label_refund_containerOL;
            label_refund_total = Properties.lang.lang.label_refund_total;
            */

        }

        private void Update_Refund()
        {


            // declaration
            BootleOneLiter bootleOneLiter = new BootleOneLiter();
            try
            {
                bootleOneLiter.Deposits_Price = double.Parse(this.txtPrice1L.Text);
            }
            catch (FormatException)
            {

                bootleOneLiter.Deposits_Price = 0;
            }
            
            BootleOverLiter bootleOverLiter = new BootleOverLiter();

            try
            {
                bootleOverLiter.Deposits_Price = double.Parse(this.txtPriceOL.Text);
            }
            catch (FormatException)
            {
                bootleOverLiter.Deposits_Price = 0;
            }


           
            
            Bill bill = new Bill(bootleOneLiter, bootleOverLiter, int.Parse(this.txtNumber1L.Text), int.Parse(this.txtNumberOL.Text));





            listView1.Items[0].SubItems[1].Text = $"{bill.RefundContainerOneLiter(bootleOneLiter.Deposits_Price),7:N2}".ToString();
            listView1.Items[1].SubItems[1].Text = $"{bill.RefundContainerOverLiter(bootleOverLiter.Deposits_Price),7:N2}".ToString();
            listView1.Items[2].SubItems[1].Text = $"{bill.TotalRefundConatiner(bootleOneLiter.Deposits_Price, bootleOverLiter.Deposits_Price),7:N2}".ToString();
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Update_Refund();
        }

        private void txtPriceOL_TextChanged(object sender, EventArgs e)
        {
            Update_Refund();
        }

        private void txtPrice1L_TextChanged(object sender, EventArgs e)
        {
            Update_Refund();
        }

        private void txtNumber1L_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Traduci("es");
        }

        private void italianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Traduci("it");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Traduci("en");
        }
    }
}
