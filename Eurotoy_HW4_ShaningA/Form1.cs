using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotoy_HW4_ShaningA
{
    public partial class Form1 : Form
    {

        decimal[] prices = { 25.00M, 15.00M, 22.00M, 8.00M, 10.00M, 12.00M, 11.00M};
        Image[] pics = new Image[7];

        //an array to capture the prices of the things the user wants to  buy
        decimal[] toBuy = new decimal[10];
        int toBuyIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populate the toys into the listbox at runtime
            Toylst.Items.Add("Rabbit puppet");
            Toylst.Items.Add("Lacing Box");
            Toylst.Items.Add("Dwarf Family");
            Toylst.Items.Add("Wooden bread loaf");
            Toylst.Items.Add("Wooden Jam Jars");
            Toylst.Items.Add("Wooden Pretzel");
            Toylst.Items.Add("Wooden Ice cream Set");

            //populate the pics array
            pics[0] = Image.FromFile("rabbit.jpg");
            pics[1] = Image.FromFile("lacingBox.jpg");
            pics[2] = Image.FromFile("dwarves.jpg");
            pics[3] = Image.FromFile("bread.jpg");
            pics[4] = Image.FromFile("jam.jpg");
            pics[5] = Image.FromFile("pretzel.jpg");
            pics[6] = Image.FromFile("iceCream.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCart.Items.Add(Toylst.SelectedItem + " - " + prices[Toylst.SelectedIndex].ToString("C"));

            toBuy[toBuyIndex] = prices[Toylst.SelectedIndex];

            toBuyIndex++; //prepare to move to the next element in the toBuy array
        }

        private void Toylst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when the user selects an item, update controls below with details
            lblToyName.Text = "Name : " + Toylst.SelectedItem.ToString();
            picToy.Image = pics[Toylst.SelectedIndex];
            lblPrice.Text = "Price : " + prices[Toylst.SelectedIndex].ToString("C");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            for (int i = 0; i < toBuyIndex; i++)
                total = total + toBuy[i];

            MessageBox.Show("Your total is: " + total.ToString("C") + "\nThank you for supporting your local Toy Store.", "THANK YOU");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyCart.Items.Clear();
            toBuyIndex = 0;
        }

        private void MyCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void ItemsDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
