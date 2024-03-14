using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private static readonly double[] value = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private double[] digit = value;

        private static readonly string[] value1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] digit_string = value1;

        private double first_number;
        private double second_number;
        private double result;
        private string operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }



        /*  ----------------  */
        /* |  NUMBERS KEYS  | */
        /*  ----------------  */
        private void n0_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(0);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(0);
            }
        }
        private void n0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad0)
            {
                n1.Enabled = true;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(1);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(1);
            }
        }
        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad1)
            {
                n1.Enabled = true;
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(2);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(2);
            }
        }
        private void n2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad2)
            {
                n1.Enabled = true;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(3);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(3);
            }
        }
        private void n3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad3)
            {
                n1.Enabled = true;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(4);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(4);
            }
        }
        private void n4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad4)
            {
                n1.Enabled = true;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(5);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(5);
            }
        }
        private void n5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad5)
            {
                n1.Enabled = true;
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(6);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(6);
            }
        }
        private void n6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad6)
            {
                n1.Enabled = true;
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(7);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(7);
            }
        }
        private void n7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad7)
            {
                n1.Enabled = true;
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(8);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(8);
            }
        }
        private void n8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad8)
            {
                n1.Enabled = true;
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text == "ERROR" && digit_line.Text != null)
            {
                digit_line.Text = (string)digit_string.GetValue(9);
            }
            else
            {
                digit_line.Text += (string)digit_string.GetValue(9);
            }
        }
        private void n9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D9)
            {
                n9.Enabled = true;
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (digit_line.Text == (string)digit_string.GetValue(0) || digit_line.Text != "ERROR" && digit_line.Text != null)
            {
                digit_line.Text += ",";
            }
        }
        private void point_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Decimal)
            {
                point.Enabled = true;
            }
        }



        /*  -----------------  */
        /* |  FUNCTION KEYS  | */
        /* |  DOUBLE ACTION  | */
        /*  -----------------  */
        private void add_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            digit_line.Text = "0";
            operation = "+";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            digit_line.Text = "0";
            operation = "-";
        }

        private void muliplicate_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            digit_line.Text = "0";
            operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            digit_line.Text = "0";
            operation = "/";
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            digit_line.Text = "0";
            operation = "%";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            second_number = Convert.ToDouble(digit_line.Text);

            if (operation == "+")
            {
                result = first_number + second_number;
                digit_line.Text = Convert.ToString(result);
                first_number = result;
            }
            if (operation == "-")
            {
                result = first_number - second_number;
                digit_line.Text = Convert.ToString(result);
                first_number = result;
            }
            if (operation == "*")
            {
                result = first_number * second_number;
                digit_line.Text = Convert.ToString(result);
                first_number = result;
            }
            if (operation == "/")
            {
                if (second_number == 0)
                {
                    digit_line.Text = "ERROR";
                }
                else
                {
                    result = first_number / second_number;
                    digit_line.Text = Convert.ToString(result);
                    first_number = result;
                }
            }
            if (operation == "%")
            {
                result = first_number % second_number;
                digit_line.Text = Convert.ToString(result);
                first_number = result;
            }
        }



        /*  -----------------  */
        /* |  FUNCTION KEYS  | */
        /* |  SINGLE ACTION  | */
        /*  -----------------  */
        private void inverse_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            
            if (first_number == 0)
            {
                digit_line.Text = "ERROR";
            }
            else
            {
                result = 1 / first_number;
                digit_line.Text = Convert.ToString(result);
                first_number = result;
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            result = first_number * first_number;
            digit_line.Text = Convert.ToString(result);
            first_number = result;
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            result = Math.Sqrt(first_number);
            digit_line.Text = Convert.ToString(result);
            first_number = result;
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(digit_line.Text);
            result = -first_number;
            digit_line.Text = Convert.ToString(result);
            first_number = result;
        }
    }
}