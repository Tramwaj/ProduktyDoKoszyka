using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProduktyDoKoszyka.Models;

namespace ProduktyDoKoszyka
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

        }
        public void Update(Product product)
        {
            lblName.Text = product.Name;
            lblDescription.Text = product.Description;
            lblPrice.Text = product.Price.ToString() + "$";
            lblCategory.Text = product.Category.ToString();
            pbxImage.ImageLocation = product.Url;
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
        }        
    }
}
