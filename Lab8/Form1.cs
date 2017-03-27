//Joshua Woosley
//LAB 8
//Due: 11/16/2014
//CIS 199-01
//This program will calculate the total cost of a trip when a number of miles is entered.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            //Declared int variables
            int input;
            int words;

            //Declared int arrays for the miles and cost respectively
            int[] miles = { 0, 100, 300, 500 };
            int[] price = { 25, 40, 55, 70 };

            //Set a new int for all of the values in the miles array
            int i = miles.Length - 1;

            //Precondition: i>=0 and input must be an integar
            //Postcondition: Must output the cost when numbers above 0 miles is entered
            //Parses the entered value and uses a while loop to determine where it lies in the miles array and compares it to the price array.
            if (int.TryParse(Miles_Text.Text, out input))
            {
                while (i >= 0 && input < miles[i])
                    --i;
                words = price[i];
                MessageBox.Show(words.ToString("c"));
            }
            else
            {
                MessageBox.Show("An interger value is needed");
            }
            
        }
    }
}
