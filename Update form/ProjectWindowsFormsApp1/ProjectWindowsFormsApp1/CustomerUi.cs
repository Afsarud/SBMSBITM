using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWindowsFormsApp1.Model;
using ProjectWindowsFormsApp1.BLL;

namespace ProjectWindowsFormsApp1
{
    public partial class CustomerUi : Form
    {
        Customers customer = new Customers();
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
