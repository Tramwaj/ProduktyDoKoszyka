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
        private Product _currentProduct;
        private Cart _cart = new Cart();
        private readonly DiscountsService _discountService = new DiscountsService();
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
            _currentProduct = _productService.Products[number - 1];
            productUserControl1.Update(_currentProduct);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            _cart.AddProduct(_currentProduct);
            lblSum.Text = _cart.Cost().ToString();
            if (_cart.Cost() != _cart.CostAfterDiscount(_discountService))
            {
                lblSumWithDiscount.Text = _cart.CostAfterDiscount(_discountService).ToString();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nie no, to już by była przesada");
        }
              
    }
}
