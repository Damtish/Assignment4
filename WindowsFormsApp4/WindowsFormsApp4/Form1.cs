using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item item1 = new item();
            item1.number=txt_number.Text;
            item1.date = txt_date.Text;
            item1.InventoryNumber = txt_inventoryNumber.Text;
            item1.ItemName=txt_itName.Text;
            item1.Quantity = txt_count.Text;
            item1.Price=txt_price.Text;

            item1.save(item1);
            MessageBox.Show($"The Item has been Added! \n Item number: " + item1.number + "\n Date: " + item1.date + "\n Inventory Number: "+ item1.InventoryNumber +"\n Item Name: "+item1.ItemName+"\n Quantity: "+item1.Quantity+"\n Price: $" + item1.Price  );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
