namespace Shop
{
    public partial class Form1 : Form
    {
        Product[] arr;
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            arr = new Product[] { new Product("intel I9", "CPU",7000), new Product("kingston 32 Gb", "SSD",9000), new Product("MSI GeForce RTX 4060", "GPU",15000) };
            foreach(var item in arr)
            {
                comboBox1.Items.Add(item.Name);

            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in arr)
            {
                if(item.Name== comboBox1.SelectedItem.ToString())
                {
                    CostLabel.Text = item.Cost.ToString();
                    break;
                }
            }
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            Product a=null;
            foreach (var item in arr)
            {
                if (item.Name == comboBox1.SelectedItem.ToString())
                {
                    a = item;
                    break;
                }
            }
            Form2 form2=new Form2(ref a);

            form2.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());
            foreach (var item in arr)
            {
                if (item.Name == comboBox1.SelectedItem.ToString())
                {
                    totalCost+= item.Cost;
                    break;
                }
            }
            TotalLabel.Text = totalCost.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox1.SelectedItem.ToString());

            foreach (var item in arr)
            {
                if (item.Name == comboBox1.SelectedItem.ToString())
                {
                    totalCost -= item.Cost;
                    break;
                }
            }
            TotalLabel.Text = totalCost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}