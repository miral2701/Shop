using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form2 : Form
    {
        public Product product { get; set; }
        public Form2(ref Product a)
        {
            InitializeComponent();
            product = a;
            label1.Text = "Name" ;
            label2.Text = "Cost" ;
            label3.Text = "Category" ;
            label4.Text = "Id" ;
            textBox1.Text = product.Name;
            textBox2.Text = product.Cost.ToString();
            textBox3.Text = product.Category;
            textBox4.Text = product.Id;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            product.Name=textBox1.Text;
            product.Cost= Convert.ToInt32(textBox2.Text);
            product.Category= textBox3.Text;
            this.Close();
        }
    }
}
