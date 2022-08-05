using _002_bootle_deposits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
