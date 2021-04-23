using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace buttonwayne99project3
{
    public partial class variablepractice : Form
    {
        public variablepractice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            label.Text = $" {playerName} is number {playerNumber}";
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = 706.85;
            label.Text = $" The area of a circle with a radius of {radius}cm is {area}cm^2";

        }

        private void carpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;
            label.Text = $"The area of a room with demensions {length} x {width} is {area}^2";
            label.Text += $"\n The cost to carpet this area at {costPerMeter} per square metre is ${totalCost}";
        }

        private void bill_Click(object sender, EventArgs e)
        {
            double shirtPrice = 12.49;
            double total = 12.49 * 1.13;
            double tax = total - shirtPrice;
            double payedWith = 20.00;
            double change = payedWith - total;
            label.Text = "Bill of sale";
            label.Text += $"\n\nShirt:   {shirtPrice}";
            label.Text += $"\n\nTax:     {tax}";
            label.Text += $"\nTotal:     {total}";
            label.Text += $"\n\nTendered:{payedWith}";
            label.Text += $"\nChange:    {change}";

        }
    }
}
