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
    public partial class Form2 : Form
    {
        private List<Product> products;
        public Form2()
        {
            InitializeComponent();
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            products = new List<Product>();
            
            Product product = new Product("caffe", 2.50);
            products.Add(product);

            listBoxBill.Items.Add(product);



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
