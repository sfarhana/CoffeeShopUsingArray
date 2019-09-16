using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class FrmCoffeeShop : Form
    {
        const int size = 10;

        string[] CustName = new string[size];
        string[] Contact = new string[size];
        string[] Address = new string[size];
        string[] Order = new string[size];
        int[] Quantity = new int[size];
        int[]Price=new int[size];

        int index = 0;
        string output = "";

        public FrmCoffeeShop()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
           
            if (index >= size)
            {
                MessageBox.Show("Sorry Customer Entry is not Available");
                return;
            }
            else
            {

                CustName[index] = nameTextBox.Text;
                Contact[index] = contactTextBox.Text;
                Address[index] = addressTextBox.Text;
                Order[index] = orderComboBox.Text;
                Quantity[index] = Convert.ToInt32(quantityTextBox.Text);

                if (Order[index] == "Black")
                {
                    Price[index] = 120 * Quantity[index];
                }
                else if (Order[index] == "Cold")
                {
                    Price[index] = 100 * Quantity[index];
                }
                else if (Order[index] == "Hot")
                {
                    Price[index] = 90 * Quantity[index];
                }
                else if (Order[index] == "Reguler")
                {
                    Price[index] = 80 * Quantity[index];
                }
                else
                {
                    MessageBox.Show("Please Place An Order");
                    return;
                }

            }

            output += "Here is your purchase info:" + Environment.NewLine + "Name:" + CustName[index]
              + Environment.NewLine + "Contact no:" + Contact[index]
              + Environment.NewLine + "Address:" + Address[index] + Environment.NewLine + "you ordered: "
              + Quantity[index].ToString() + " " + Order[index] + " Coffee" + Environment.NewLine
              + "Your Payment Bill is: " + Price[index].ToString() + Environment.NewLine + Environment.NewLine;

            richTextBox.Text = output;
            index++;
           

        }
    }
}
