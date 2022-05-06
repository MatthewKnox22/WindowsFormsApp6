using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get integer from user
            // any integer > 1

            int upperLimit;

            // create predicate

            Predicate<int> IsPrime = delegate (int x)
            {
                bool isPrimeNUmber = true;

                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isPrimeNUmber = false;
                    }
                }
                return isPrimeNUmber;

            };
            // get the number
            if (int.TryParse(textBox1.Text, out upperLimit)) 
            {
                if (upperLimit > 1)
                {
                    List<int> numbers = new List<int>();
                    for (int i = 2; i <= upperLimit; i++)
                    {
                        numbers.Add(i);
                    }
                    List<int> primes = numbers.FindAll(IsPrime);

                    //Display prine number
                    foreach (int i in primes)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    MessageBox.Show("The number must be greater than 1.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a vaild integer.");
            }


        }
    }
}