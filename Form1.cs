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
	public partial class MainWindow : Form
	{
		private double result;
		private bool clear;
		private string operation;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void buttonEqual_Click(object sender, EventArgs e)
		{
			switch (operation)
			{
				case "+":
					textBoxShow.Text = Convert.ToString(result + Convert.ToDouble(textBoxShow.Text));
					break;
				case "-":
					textBoxShow.Text = Convert.ToString(result - Convert.ToDouble(textBoxShow.Text));
					break;
				case "*":
					textBoxShow.Text = Convert.ToString(result * Convert.ToDouble(textBoxShow.Text));
					break;
				case "/":
					textBoxShow.Text = Convert.ToString(result / Convert.ToDouble(textBoxShow.Text));
					break;
			}
			result = Convert.ToDouble(textBoxShow.Text);
			operation = "";
			clear = true;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxShow.Text = "0";
		}

		private void buttonPoint_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (!textBoxShow.Text.Contains("."))
			{
				textBoxShow.AppendText(".");
			}
		}

		private void button0_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if(textBoxShow.Text != "0")
			{
				textBoxShow.AppendText(button0.Text);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-")  || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text=="0")
			{
				textBoxShow.Text = button1.Text;
			}
			else
			{
				textBoxShow.AppendText(button1.Text);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button2.Text;
			}
			else
			{
				textBoxShow.AppendText(button2.Text);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button3.Text;
			}
			else
			{
				textBoxShow.AppendText(button3.Text);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button4.Text;
			}
			else
			{
				textBoxShow.AppendText(button4.Text);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button5.Text;
			}
			else
			{
				textBoxShow.AppendText(button5.Text);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button6.Text;
			}
			else
			{
				textBoxShow.AppendText(button6.Text);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button7.Text;
			}
			else
			{
				textBoxShow.AppendText(button7.Text);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button8.Text;
			}
			else
			{
				textBoxShow.AppendText(button8.Text);
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (clear)
			{
				textBoxShow.Text = "0";
				clear = false;
			}
			if (textBoxShow.Text.Contains("+") || textBoxShow.Text.Contains("-") || textBoxShow.Text.Contains("*") || textBoxShow.Text.Contains("/") || textBoxShow.Text == "0")
			{
				textBoxShow.Text = button9.Text;
			}
			else
			{
				textBoxShow.AppendText(button9.Text);
			}
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			if(result !=0)
			{
				buttonEqual.PerformClick();
				operation = buttonPlus.Text;
				textBoxShow.Text = Convert.ToString(result) + " " + buttonPlus.Text;
			}
			else
			{
				operation = buttonPlus.Text;
				result = Convert.ToDouble(textBoxShow.Text);
				textBoxShow.Text = Convert.ToString(result) + " " + buttonPlus.Text;
			}
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			if (result != 0)
			{
				buttonEqual.PerformClick();
				operation = buttonMinus.Text;
				textBoxShow.Text = Convert.ToString(result) + " " + buttonMinus.Text;
			}
			else
			{
				operation = buttonMinus.Text;
				result = Convert.ToDouble(textBoxShow.Text);
				textBoxShow.Text = Convert.ToString(result) + " " + buttonMinus.Text;
			}
		}

		private void buttonMult_Click(object sender, EventArgs e)
		{
			if (result != 0)
			{
				buttonEqual.PerformClick();
				operation = buttonMult.Text;
				textBoxShow.Text = Convert.ToString(result) + " " + buttonMult.Text;
			}
			else
			{
				operation = buttonMult.Text;
				result = Convert.ToDouble(textBoxShow.Text);
				textBoxShow.Text = Convert.ToString(result) + " " + buttonMult.Text;
			}
		}

		private void buttonDiv_Click(object sender, EventArgs e)
		{
			if (result != 0)
			{
				buttonEqual.PerformClick();
				operation = buttonDiv.Text;
				textBoxShow.Text = Convert.ToString(result) + " " + buttonDiv.Text;
			}
			else
			{
				operation = buttonDiv.Text;
				result = Convert.ToDouble(textBoxShow.Text);
				textBoxShow.Text = Convert.ToString(result) + " " + buttonDiv.Text;
			}
		}
	}
}
