using ProectWindowsFormsApp1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProectWindowsFormsApp1.Model;

namespace ProectWindowsFormsApp1
{
    public partial class Product : Form
    {
        

        public Product()
        {
            InitializeComponent();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           //categoryComboBox.DataSource=
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductManager _productManager = new ProductManager();
            Product _product = new Product();

            _product.ProductCode = productCodeTextBox.Text;
            _product.ProductName = productNameTextBox.Text;
            _product.ReorderLevel = Convert.ToInt32(reOrderLevelTextBox.Text);
            _product.ProductDescription = descriptionTextBox.Text;


            showDataGridView.DataSource = _productManager.Add(_product);

        }
        
    }
}
