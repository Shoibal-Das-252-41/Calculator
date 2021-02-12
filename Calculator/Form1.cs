using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_button(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstTextBox.Text) + Convert.ToDouble(secondTextBox.Text);

            resultTextBox.Text = result.ToString();
        }

        private void Sub_button(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstTextBox.Text) - Convert.ToDouble(secondTextBox.Text);

            resultTextBox.Text = result.ToString();
        }

        private void Mul_button(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstTextBox.Text) * Convert.ToDouble(secondTextBox.Text);

            resultTextBox.Text = result.ToString();
        }

        private void Div_button(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstTextBox.Text) / Convert.ToDouble(secondTextBox.Text);

            resultTextBox.Text = result.ToString();
        }

        private void Clear_button(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            firstTextBox.Clear();
            secondTextBox.Clear();
        }
        
        private void Root_button(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(resultTextBox.Text);
            result = Convert.ToDouble(Math.Sqrt(result));

            resultTextBox.Text = result.ToString();
        }
    }
}
