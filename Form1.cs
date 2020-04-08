using ProduktyDoKoszyka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProduktyDoKoszyka
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService = new ProductService();
        public Form1()
        {
            InitializeComponent();
            var cart = new Cart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayProduct(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            displayProduct(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            displayProduct(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            displayProduct(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            displayProduct(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            displayProduct(6);
        }
        private void displayProduct(int number)
        {
            productUserControl1.Update(_productService.Products[number-1]);
        }
    }
}
